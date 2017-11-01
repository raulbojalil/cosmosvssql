using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure.Graphs;
using Microsoft.Azure.Documents.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CosmosVsSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly string COSMOSDB_TESTCOLLECTIONNAME = "tests3";
        private readonly string COSMOSDB_TESTDATABASENAME = "tests";
        private readonly string SQL_TESTCOLLECTIONNAME = "tests";

        private void EnableUI(bool enabled, string message, bool includeStaggeredBtns = true)
        {
            menuStrip1.Enabled = enabled;
            txtCosmosEndpoint.Enabled = enabled;
            txtCosmosAuthToken.Enabled = enabled;
            txtSQLConnString.Enabled = enabled;
            nudCosmosDocumentCount.Enabled = enabled;
            nudSQLRecordsCount.Enabled = enabled;

            btnCosmosRead.Enabled = enabled;
            btnCosmosInsert.Enabled = enabled;
            btnCosmosDelete.Enabled = enabled;

            btnSQLRead.Enabled = enabled;
            btnSQLInsert.Enabled = enabled;
            btnSQLDelete.Enabled = enabled;

            btnGraphInsert.Enabled = enabled;
            btnGraphTraverse.Enabled = enabled;
            btnGraphDrop.Enabled = enabled;

            if(includeStaggeredBtns)
            {
                btnCosmosStaggered.Enabled = enabled;
                btnSQLStaggered.Enabled = enabled;
            }

            toolStripStatusLabel1.Text = message;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Raúl Bojalil");
        }

        private void btnCosmosInsert_Click(object sender, EventArgs e)
        {
            PerformCosmosTest("CosmosDB Document Insertion", InsertDocumentsIntoCosmosDB);
        }

        private void btnCosmosRead_Click(object sender, EventArgs e)
        {
            PerformCosmosTest("CosmosDB Document Reading", ReadDocumentsFromCosmosDB);
        }

        private void btnCosmosDelete_Click(object sender, EventArgs e)
        {
            PerformCosmosTest("CosmosDB Document Deletion", DeleteDocumentsFromCosmosDB);
        }

        private void btnSQLInsert_Click(object sender, EventArgs e)
        {
            PerformSQLTest("SQL Insertion", InsertRecordsIntoSQL);
        }

        private void btnSQLRead_Click(object sender, EventArgs e)
        {
            PerformSQLTest("SQL Reading", ReadRecordsFromSQL);
        }

        private void btnSQLDelete_Click(object sender, EventArgs e)
        {
            PerformSQLTest("SQL Deletion", DeleteRecordsFromSQL);
        }

        private void btnGraphInsert_Click(object sender, EventArgs e)
        {
            PerformCosmosTest("Graph Vertices Insertion", AddVertices);
        }

        private void btnGraphTraverse_Click(object sender, EventArgs e)
        {
            PerformCosmosTest("Graph Vertices Reading", ReadVertices);
        }

        private void btnGraphDrop_Click(object sender, EventArgs e)
        {
            PerformCosmosTest("Graph Vertices Deletion", DropVertices);
        }

        private void btnCosmosResultsClear_Click(object sender, EventArgs e)
        {
            txtCosmosResults.Clear();
        }

        private void btnSQLResultsClear_Click(object sender, EventArgs e)
        {
            txtSQLResults.Clear();
        }

        Random rand = new Random();
        private async Task RunWriteReadTest(string sqlConnectionString, string cosmosEndpoint, string cosmosAuthKey)
        {
            var insertCount = rand.Next(100, 500);
            var readCount = rand.Next(100, 500);

            var insertCosmosTask = InsertDocumentsIntoCosmosDB(cosmosEndpoint, cosmosAuthKey, insertCount);
            var readCosmosTask = ReadDocumentsFromCosmosDB(cosmosEndpoint, cosmosAuthKey, readCount);

            await Task.WhenAll(insertCosmosTask, readCosmosTask);

            BeginInvoke(new Action(() => {
                txtCosmosResults.AppendText(insertCosmosTask.Result + "\r\n" + readCosmosTask.Result + "\r\n");
            }));

            var insertSQLTask = InsertRecordsIntoSQL(sqlConnectionString, insertCount);
            var readSQLTask = ReadRecordsFromSQL(sqlConnectionString, readCount);

            await Task.WhenAll(insertSQLTask, readSQLTask);

            BeginInvoke(new Action(() => {
                txtSQLResults.AppendText(insertSQLTask.Result + "\r\n" + readSQLTask.Result + "\r\n");
            }));

        }

        bool runningStaggeredTest = false;
        private void btnStaggered_Click(object sender, EventArgs e)
        {
            runningStaggeredTest = !runningStaggeredTest;

            if (runningStaggeredTest)
            {
                EnableUI(false, "Running staggered test...", false);
                btnSQLStaggered.Text = "STOP";
                btnCosmosStaggered.Text = "STOP";

                var sqlConnectionString = txtSQLConnString.Text;
                var cosmosEndpoint = txtCosmosEndpoint.Text;
                var cosmosAuthKey = txtCosmosAuthToken.Text;

                var staggeredTask = new Task(new Action(async () =>
                {
                    while (runningStaggeredTest)
                    {
                        await RunWriteReadTest(sqlConnectionString, cosmosEndpoint, cosmosAuthKey);
                        Thread.Sleep(2000);
                    }

                    BeginInvoke(new Action(() => {
                        EnableUI(true, "Staggered test complete.");
                    }));
                    
                }));

                staggeredTask.Start();
            }
            else
            {
                EnableUI(false, "Stopping test, please wait...");
                btnSQLStaggered.Text = "Staggered test";
                btnCosmosStaggered.Text = "Staggered test";
            }
        }



        #region DocumentDB Tests

        private void PerformCosmosTest(string testName, Func<string, string, int, Task<string>> method)
        {
            EnableUI(false, $"Performing '{testName}' test...");
            var endpoint = txtCosmosEndpoint.Text;
            var authKey = txtCosmosAuthToken.Text;
            var count = (int)nudCosmosDocumentCount.Value;

            var task = new Task(async () =>
            {
                var result = await method(endpoint, authKey, count);

                BeginInvoke(new Action(() => {
                    EnableUI(true, "Process complete");
                    var currentDateTime = DateTime.Now;
                    txtCosmosResults.AppendText($"[{currentDateTime.ToShortDateString()} {currentDateTime.ToShortTimeString()}] {result}\r\n");
                }));

            });
            task.Start();
        }

        private async Task<string> InsertDocumentsIntoCosmosDB(string endpoint, string authKey, int count)
        {
            try
            {
                var stopWatch = new Stopwatch();
                var client = DocumentDBHelper.InitializeClient(endpoint, authKey);
                var collection = await DocumentDBHelper.CreateCollectionIfNotExists(client, COSMOSDB_TESTDATABASENAME, COSMOSDB_TESTCOLLECTIONNAME);

                stopWatch.Start();

                var tasks = new List<Task>();

                for (var i = 0; i < count; i++)
                {
                    var user = new User()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Email = Guid.NewGuid().ToString(),
                        Address = Guid.NewGuid().ToString(),
                        FirstName = Guid.NewGuid().ToString(),
                        LastName = Guid.NewGuid().ToString()
                    };
                    tasks.Add(client.UpsertDocumentAsync(collection.DocumentsLink, user));
                }

                await Task.WhenAll(tasks);

                stopWatch.Stop();

                return $"{count} document(s) inserted. Ellapsed time: {stopWatch.ElapsedMilliseconds} ms.";
            }
            catch (AggregateException ex)
            {
                return $"ERROR. {String.Join(Environment.NewLine, ex.InnerExceptions.Select(e => e.Message))}";
            }
            catch (Exception ex)
            {
                return $"ERROR. {ex.Message}";
            }
        }

        private async Task<string> ReadDocumentsFromCosmosDB(string endpoint, string authKey, int count)
        {
            try
            {
                var stopWatch = new Stopwatch();
                var client = DocumentDBHelper.InitializeClient(endpoint, authKey);
                var collection = await DocumentDBHelper.CreateCollectionIfNotExists(client, COSMOSDB_TESTDATABASENAME, COSMOSDB_TESTCOLLECTIONNAME);

                stopWatch.Start();

                var tasks = new List<Task>();

                var documents = client.CreateDocumentQuery<User>(collection.DocumentsLink, $"SELECT TOP {count} * FROM tests", new FeedOptions() { MaxItemCount = count /*, EnableCrossPartitionQuery = true*/ });
                var list = documents.ToList();

                stopWatch.Stop();

                return $"{list.Count} document(s) read. Ellapsed time: {stopWatch.ElapsedMilliseconds} ms.";
            }
            catch (AggregateException ex)
            {
                return $"ERROR. {String.Join(Environment.NewLine, ex.InnerExceptions.Select(e => e.Message))}";
            }
            catch (Exception ex)
            {
                return $"ERROR. {ex.Message}";
            }
        }

        private async Task<string> DeleteDocumentsFromCosmosDB(string endpoint, string authKey, int count)
        {
            try
            {
                var stopWatch = new Stopwatch();
                var client = DocumentDBHelper.InitializeClient(endpoint, authKey);
                var collection = await DocumentDBHelper.CreateCollectionIfNotExists(client, COSMOSDB_TESTDATABASENAME, COSMOSDB_TESTCOLLECTIONNAME);

                stopWatch.Start();

                var tasks = new List<Task>();

                var documents = client.CreateDocumentQuery<Document>(collection.DocumentsLink, $"SELECT TOP {count} * FROM tests", new FeedOptions() { MaxItemCount = count/*, EnableCrossPartitionQuery = true*/  });
                var deleteCount = 0;
                foreach (var document in documents)
                {
                    deleteCount++;
                    tasks.Add(client.DeleteDocumentAsync(document.SelfLink));
                }

                await Task.WhenAll(tasks);

                stopWatch.Stop();

                return $"{deleteCount} document(s) deleted. Ellapsed time: {stopWatch.ElapsedMilliseconds} ms.";
            }
            catch (AggregateException ex)
            {
                return $"ERROR. {String.Join(Environment.NewLine, ex.InnerExceptions.Select(e => e.Message))}";
            }
            catch (Exception ex)
            {
                return $"ERROR. {ex.Message}";
            }
        }

        #endregion

        #region SQL Tests

        private void PerformSQLTest(string testName, Func<string, int, Task<string>> method)
        {
            EnableUI(false, $"Performing '{testName}' test...");
            var connectionString = txtSQLConnString.Text;
            var count = (int)nudSQLRecordsCount.Value;


            var task = new Task(async () =>
            {
                var result = await method(connectionString, count);

                BeginInvoke(new Action(() => {
                    EnableUI(true, "Process complete");
                    var currentDateTime = DateTime.Now;
                    txtSQLResults.AppendText($"[{currentDateTime.ToShortDateString()} {currentDateTime.ToShortTimeString()}] {result}\r\n");
                }));

            });
            task.Start();
        }

        private async Task<string> InsertRecordsIntoSQL(string connectionString, int count)
        {
            try
            {
                var stopWatch = new Stopwatch();
                stopWatch.Start();

                var tasks = new List<Task>();

                using (var sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    var transaction = sqlConnection.BeginTransaction();

                    for (var i = 0; i < count; i++)
                    {
                        var query = $@"INSERT INTO {SQL_TESTCOLLECTIONNAME} (Id, Email, Address, FirstName, LastName)
                                       VALUES ('{Guid.NewGuid().ToString()}','{Guid.NewGuid().ToString()}', '{Guid.NewGuid().ToString()}', '{Guid.NewGuid().ToString()}', '{Guid.NewGuid().ToString()}');";
                        using (SqlCommand cmd = new SqlCommand(query, sqlConnection, transaction))
                        {
                            //tasks.Add(cmd.ExecuteNonQueryAsync());
                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    //await Task.WhenAll(tasks);
                }

                stopWatch.Stop();

                return $"{count} row(s) inserted. Ellapsed time: {stopWatch.ElapsedMilliseconds} ms.";
            }
            catch (Exception ex)
            {
                return $"ERROR. {ex.Message}";
            }
        }

        private async Task<string> ReadRecordsFromSQL(string connectionString, int count)
        {
            try
            {
                var stopWatch = new Stopwatch();
                stopWatch.Start();

                var tasks = new List<Task>();
                var list = new List<User>();

                using (var sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    using (SqlCommand cmd = new SqlCommand($"SELECT TOP {count} *  FROM {SQL_TESTCOLLECTIONNAME}", sqlConnection))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                list.Add(new User()
                                {
                                    Id = (string)reader[0],
                                    LastName = (string)reader[1],
                                    FirstName = (string)reader[2],
                                    Email = (string)reader[3],
                                    Address = (string)reader[4]
                                });
                            }
                        }
                    }
                }

                stopWatch.Stop();

                return $"{list.Count} row(s) read. Ellapsed time: {stopWatch.ElapsedMilliseconds} ms.";
            }
            catch (Exception ex)
            {
                return $"ERROR. {ex.Message}";
            }
        }

        private async Task<string> DeleteRecordsFromSQL(string connectionString, int count)
        {
            try
            {
                var stopWatch = new Stopwatch();
                stopWatch.Start();

                using (var sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    using (SqlCommand cmd = new SqlCommand($"DELETE TOP ({count}) FROM {SQL_TESTCOLLECTIONNAME}", sqlConnection))
                    {
                        await cmd.ExecuteNonQueryAsync();
                    }
                }

                stopWatch.Stop();

                return $"{count} row(s) deleted. Ellapsed time: {stopWatch.ElapsedMilliseconds} ms.";
            }
            catch (Exception ex)
            {
                return $"ERROR. {ex.Message}";
            }
        }

        #endregion

        #region GraphAPI Tests

        private async Task<string> AddVertices(string endpoint, string authKey, int count)
        {
            try
            {
                var stopWatch = new Stopwatch();
                var client = DocumentDBHelper.InitializeClient(endpoint, authKey);
                var graph = await DocumentDBHelper.CreateCollectionIfNotExists(client, COSMOSDB_TESTDATABASENAME, COSMOSDB_TESTCOLLECTIONNAME);

                stopWatch.Start();

                var tasks = new List<Task>();

                for (var i = 0; i < count; i++)
                {
                    var query = client.CreateGremlinQuery<dynamic>(graph,
                        $"g.addV('user').property('id', '{Guid.NewGuid().ToString()}').property('Email', '{Guid.NewGuid().ToString()}').property('Address', '{Guid.NewGuid().ToString()}').property('FirstName', '{Guid.NewGuid().ToString()}').property('LastName', '{Guid.NewGuid().ToString()}')"
                    );
                    tasks.Add(query.ExecuteNextAsync());
                }

                await Task.WhenAll(tasks);
                stopWatch.Stop();

                return $"{count} vertex(ices) added. Ellapsed time: {stopWatch.ElapsedMilliseconds} ms.";
            }
            catch (AggregateException ex)
            {
                return $"ERROR. {String.Join(Environment.NewLine, ex.InnerExceptions.Select(e => e.Message))}";
            }
            catch (Exception ex)
            {
                return $"ERROR. {ex.Message}";
            }
        }

        private async Task<string> ReadVertices(string endpoint, string authKey, int count)
        {
            try
            {
                var stopWatch = new Stopwatch();
                var client = DocumentDBHelper.InitializeClient(endpoint, authKey);
                var graph = await DocumentDBHelper.CreateCollectionIfNotExists(client, COSMOSDB_TESTDATABASENAME, COSMOSDB_TESTCOLLECTIONNAME);

                var list = new List<User>();

                stopWatch.Start();

                var query = client.CreateGremlinQuery<dynamic>(graph,
                    $"g.V().hasLabel('user').limit({count})"
                );

                while (query.HasMoreResults)
                {
                    foreach (JObject result in await query.ExecuteNextAsync<JObject>())
                    {
                        var properties = result["properties"];
                        list.Add(new User()
                        {
                            Id = result["id"].Value<string>(),
                            Email = properties["Email"][0]["value"].Value<string>(),
                            Address = properties["Address"][0]["value"].Value<string>(),
                            FirstName = properties["FirstName"][0]["value"].Value<string>(),
                            LastName = properties["LastName"][0]["value"].Value<string>()
                        });
                    }
                }

                stopWatch.Stop();

                return $"{list.Count} vertex(ices) read. Ellapsed time: {stopWatch.ElapsedMilliseconds} ms.";
            }
            catch (AggregateException ex)
            {
                return $"ERROR. {String.Join(Environment.NewLine, ex.InnerExceptions.Select(e => e.Message))}";
            }
            catch (Exception ex)
            {
                return $"ERROR. {ex.Message}";
            }
        }

        private async Task<string> DropVertices(string endpoint, string authKey, int count)
        {
            try
            {
                var stopWatch = new Stopwatch();
                var client = DocumentDBHelper.InitializeClient(endpoint, authKey);
                var graph = await DocumentDBHelper.CreateCollectionIfNotExists(client, COSMOSDB_TESTDATABASENAME, COSMOSDB_TESTCOLLECTIONNAME);

                var list = new List<Task>();

                var countQuery = client.CreateGremlinQuery<dynamic>(graph,
                    $"g.V().hasLabel('user').count()"
                );

                var countResponse = await countQuery.ExecuteNextAsync();
                var countResult = (int)countResponse.FirstOrDefault();

                var dropCount = Math.Min(countResult, count);

                stopWatch.Start();

                var query = client.CreateGremlinQuery<dynamic>(graph,
                    $"g.V().hasLabel('user').limit({count}).drop()"
                );

                var result = await query.ExecuteNextAsync();

                stopWatch.Stop();

                return $"{dropCount} vertex(ices) dropped. Ellapsed time: {stopWatch.ElapsedMilliseconds} ms.";
            }
            catch (AggregateException ex)
            {
                return $"ERROR. {String.Join(Environment.NewLine, ex.InnerExceptions.Select(e => e.Message))}";
            }
            catch (Exception ex)
            {
                return $"ERROR. {ex.Message}";
            }
        }

        #endregion


    }
}
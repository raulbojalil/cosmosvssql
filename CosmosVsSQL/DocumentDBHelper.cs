using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosVsSQL
{
    public class DocumentDBHelper
    {

        public static DocumentClient InitializeClient(string endpoint, string authKey)
        {
            return new DocumentClient(new Uri(endpoint), authKey);
        }

        public static async Task CreateDocument<T>(DocumentClient client, string databaseName, string collectionName, T document)
        {
            await client.CreateDocumentAsync(UriFactory.CreateDocumentCollectionUri(databaseName, collectionName), document);
        }

        public static IOrderedQueryable<T> CreateDocumentQuery<T>(DocumentClient client, string databaseName, string collectionName)
        {
            return client.CreateDocumentQuery<T>(UriFactory.CreateDocumentCollectionUri(databaseName, collectionName), new FeedOptions { EnableCrossPartitionQuery = true });
        }

        public static async Task<Database> CreateDatabaseIfNotExists(DocumentClient client, string databaseId)
        {
            return await client.CreateDatabaseIfNotExistsAsync(new Database { Id = databaseId });
        }

        public static async Task<DocumentCollection> CreateCollectionIfNotExists(DocumentClient client, string databaseId, string collectionId, string partitionKeyPath = null)
        {
            return await client.CreateDocumentCollectionIfNotExistsAsync(
                UriFactory.CreateDatabaseUri(databaseId),
                        string.IsNullOrEmpty(partitionKeyPath) ? new DocumentCollection() {  Id = collectionId } : 
                        new DocumentCollection
                        {
                            Id = collectionId,
                            PartitionKey = new PartitionKeyDefinition() { Paths = new Collection<string>() { partitionKeyPath } }
                        },
                        new RequestOptions { OfferThroughput = 10000 }
                );
        }
    }
}

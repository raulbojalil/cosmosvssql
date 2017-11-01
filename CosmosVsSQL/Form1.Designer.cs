namespace CosmosVsSQL
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGraphDrop = new System.Windows.Forms.Button();
            this.btnGraphTraverse = new System.Windows.Forms.Button();
            this.btnGraphInsert = new System.Windows.Forms.Button();
            this.btnCosmosResultsClear = new System.Windows.Forms.Button();
            this.btnCosmosStaggered = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCosmosDelete = new System.Windows.Forms.Button();
            this.btnCosmosRead = new System.Windows.Forms.Button();
            this.btnCosmosInsert = new System.Windows.Forms.Button();
            this.txtCosmosResults = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudCosmosDocumentCount = new System.Windows.Forms.NumericUpDown();
            this.txtCosmosAuthToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCosmosEndpoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSQLResultsClear = new System.Windows.Forms.Button();
            this.btnSQLStaggered = new System.Windows.Forms.Button();
            this.nudSQLRecordsCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSQLDelete = new System.Windows.Forms.Button();
            this.btnSQLRead = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSQLInsert = new System.Windows.Forms.Button();
            this.txtSQLConnString = new System.Windows.Forms.TextBox();
            this.txtSQLResults = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosmosDocumentCount)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSQLRecordsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 520);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1016, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnGraphDrop);
            this.groupBox1.Controls.Add(this.btnGraphTraverse);
            this.groupBox1.Controls.Add(this.btnGraphInsert);
            this.groupBox1.Controls.Add(this.btnCosmosResultsClear);
            this.groupBox1.Controls.Add(this.btnCosmosStaggered);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnCosmosDelete);
            this.groupBox1.Controls.Add(this.btnCosmosRead);
            this.groupBox1.Controls.Add(this.btnCosmosInsert);
            this.groupBox1.Controls.Add(this.txtCosmosResults);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudCosmosDocumentCount);
            this.groupBox1.Controls.Add(this.txtCosmosAuthToken);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCosmosEndpoint);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 490);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Azure Cosmos DB";
            // 
            // btnGraphDrop
            // 
            this.btnGraphDrop.Location = new System.Drawing.Point(228, 180);
            this.btnGraphDrop.Name = "btnGraphDrop";
            this.btnGraphDrop.Size = new System.Drawing.Size(100, 39);
            this.btnGraphDrop.TabIndex = 22;
            this.btnGraphDrop.Text = "GraphAPI Drop Test";
            this.btnGraphDrop.UseVisualStyleBackColor = true;
            this.btnGraphDrop.Click += new System.EventHandler(this.btnGraphDrop_Click);
            // 
            // btnGraphTraverse
            // 
            this.btnGraphTraverse.Location = new System.Drawing.Point(122, 180);
            this.btnGraphTraverse.Name = "btnGraphTraverse";
            this.btnGraphTraverse.Size = new System.Drawing.Size(100, 39);
            this.btnGraphTraverse.TabIndex = 20;
            this.btnGraphTraverse.Text = "GraphAPI Read Test";
            this.btnGraphTraverse.UseVisualStyleBackColor = true;
            this.btnGraphTraverse.Click += new System.EventHandler(this.btnGraphTraverse_Click);
            // 
            // btnGraphInsert
            // 
            this.btnGraphInsert.Location = new System.Drawing.Point(16, 180);
            this.btnGraphInsert.Name = "btnGraphInsert";
            this.btnGraphInsert.Size = new System.Drawing.Size(100, 39);
            this.btnGraphInsert.TabIndex = 19;
            this.btnGraphInsert.Text = "GraphAPI Insert Test";
            this.btnGraphInsert.UseVisualStyleBackColor = true;
            this.btnGraphInsert.Click += new System.EventHandler(this.btnGraphInsert_Click);
            // 
            // btnCosmosResultsClear
            // 
            this.btnCosmosResultsClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCosmosResultsClear.Location = new System.Drawing.Point(330, 230);
            this.btnCosmosResultsClear.Name = "btnCosmosResultsClear";
            this.btnCosmosResultsClear.Size = new System.Drawing.Size(100, 23);
            this.btnCosmosResultsClear.TabIndex = 18;
            this.btnCosmosResultsClear.Text = "CLEAR";
            this.btnCosmosResultsClear.UseVisualStyleBackColor = true;
            this.btnCosmosResultsClear.Click += new System.EventHandler(this.btnCosmosResultsClear_Click);
            // 
            // btnCosmosStaggered
            // 
            this.btnCosmosStaggered.Location = new System.Drawing.Point(334, 135);
            this.btnCosmosStaggered.Name = "btnCosmosStaggered";
            this.btnCosmosStaggered.Size = new System.Drawing.Size(100, 39);
            this.btnCosmosStaggered.TabIndex = 12;
            this.btnCosmosStaggered.Text = "DocumentDB Staggered test";
            this.btnCosmosStaggered.UseVisualStyleBackColor = true;
            this.btnCosmosStaggered.Click += new System.EventHandler(this.btnStaggered_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Results:";
            // 
            // btnCosmosDelete
            // 
            this.btnCosmosDelete.Location = new System.Drawing.Point(228, 135);
            this.btnCosmosDelete.Name = "btnCosmosDelete";
            this.btnCosmosDelete.Size = new System.Drawing.Size(100, 39);
            this.btnCosmosDelete.TabIndex = 10;
            this.btnCosmosDelete.Text = "DocumentDB Delete test";
            this.btnCosmosDelete.UseVisualStyleBackColor = true;
            this.btnCosmosDelete.Click += new System.EventHandler(this.btnCosmosDelete_Click);
            // 
            // btnCosmosRead
            // 
            this.btnCosmosRead.Location = new System.Drawing.Point(122, 135);
            this.btnCosmosRead.Name = "btnCosmosRead";
            this.btnCosmosRead.Size = new System.Drawing.Size(100, 39);
            this.btnCosmosRead.TabIndex = 9;
            this.btnCosmosRead.Text = "DocumentDB Read test";
            this.btnCosmosRead.UseVisualStyleBackColor = true;
            this.btnCosmosRead.Click += new System.EventHandler(this.btnCosmosRead_Click);
            // 
            // btnCosmosInsert
            // 
            this.btnCosmosInsert.Location = new System.Drawing.Point(16, 135);
            this.btnCosmosInsert.Name = "btnCosmosInsert";
            this.btnCosmosInsert.Size = new System.Drawing.Size(100, 39);
            this.btnCosmosInsert.TabIndex = 8;
            this.btnCosmosInsert.Text = "DocumentDB Insert Test";
            this.btnCosmosInsert.UseVisualStyleBackColor = true;
            this.btnCosmosInsert.Click += new System.EventHandler(this.btnCosmosInsert_Click);
            // 
            // txtCosmosResults
            // 
            this.txtCosmosResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCosmosResults.Location = new System.Drawing.Point(16, 255);
            this.txtCosmosResults.Multiline = true;
            this.txtCosmosResults.Name = "txtCosmosResults";
            this.txtCosmosResults.ReadOnly = true;
            this.txtCosmosResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCosmosResults.Size = new System.Drawing.Size(414, 220);
            this.txtCosmosResults.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Documents/vertices to test:";
            // 
            // nudCosmosDocumentCount
            // 
            this.nudCosmosDocumentCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCosmosDocumentCount.Location = new System.Drawing.Point(160, 96);
            this.nudCosmosDocumentCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCosmosDocumentCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCosmosDocumentCount.Name = "nudCosmosDocumentCount";
            this.nudCosmosDocumentCount.Size = new System.Drawing.Size(270, 20);
            this.nudCosmosDocumentCount.TabIndex = 4;
            this.nudCosmosDocumentCount.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // txtCosmosAuthToken
            // 
            this.txtCosmosAuthToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCosmosAuthToken.Location = new System.Drawing.Point(88, 55);
            this.txtCosmosAuthToken.Name = "txtCosmosAuthToken";
            this.txtCosmosAuthToken.Size = new System.Drawing.Size(342, 20);
            this.txtCosmosAuthToken.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Auth Token:";
            // 
            // txtCosmosEndpoint
            // 
            this.txtCosmosEndpoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCosmosEndpoint.Location = new System.Drawing.Point(88, 29);
            this.txtCosmosEndpoint.Name = "txtCosmosEndpoint";
            this.txtCosmosEndpoint.Size = new System.Drawing.Size(342, 20);
            this.txtCosmosEndpoint.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endpoint:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnSQLResultsClear);
            this.groupBox2.Controls.Add(this.btnSQLStaggered);
            this.groupBox2.Controls.Add(this.nudSQLRecordsCount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnSQLDelete);
            this.groupBox2.Controls.Add(this.btnSQLRead);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnSQLInsert);
            this.groupBox2.Controls.Add(this.txtSQLConnString);
            this.groupBox2.Controls.Add(this.txtSQLResults);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 493);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SQL Azure";
            // 
            // btnSQLResultsClear
            // 
            this.btnSQLResultsClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSQLResultsClear.Location = new System.Drawing.Point(434, 140);
            this.btnSQLResultsClear.Name = "btnSQLResultsClear";
            this.btnSQLResultsClear.Size = new System.Drawing.Size(100, 21);
            this.btnSQLResultsClear.TabIndex = 17;
            this.btnSQLResultsClear.Text = "CLEAR";
            this.btnSQLResultsClear.UseVisualStyleBackColor = true;
            this.btnSQLResultsClear.Click += new System.EventHandler(this.btnSQLResultsClear_Click);
            // 
            // btnSQLStaggered
            // 
            this.btnSQLStaggered.Location = new System.Drawing.Point(336, 92);
            this.btnSQLStaggered.Name = "btnSQLStaggered";
            this.btnSQLStaggered.Size = new System.Drawing.Size(100, 39);
            this.btnSQLStaggered.TabIndex = 13;
            this.btnSQLStaggered.Text = "Staggered test";
            this.btnSQLStaggered.UseVisualStyleBackColor = true;
            this.btnSQLStaggered.Click += new System.EventHandler(this.btnStaggered_Click);
            // 
            // nudSQLRecordsCount
            // 
            this.nudSQLRecordsCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSQLRecordsCount.Location = new System.Drawing.Point(115, 60);
            this.nudSQLRecordsCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSQLRecordsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSQLRecordsCount.Name = "nudSQLRecordsCount";
            this.nudSQLRecordsCount.Size = new System.Drawing.Size(416, 20);
            this.nudSQLRecordsCount.TabIndex = 12;
            this.nudSQLRecordsCount.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Results:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Connection String:";
            // 
            // btnSQLDelete
            // 
            this.btnSQLDelete.Location = new System.Drawing.Point(230, 92);
            this.btnSQLDelete.Name = "btnSQLDelete";
            this.btnSQLDelete.Size = new System.Drawing.Size(100, 39);
            this.btnSQLDelete.TabIndex = 15;
            this.btnSQLDelete.Text = "Delete test";
            this.btnSQLDelete.UseVisualStyleBackColor = true;
            this.btnSQLDelete.Click += new System.EventHandler(this.btnSQLDelete_Click);
            // 
            // btnSQLRead
            // 
            this.btnSQLRead.Location = new System.Drawing.Point(124, 92);
            this.btnSQLRead.Name = "btnSQLRead";
            this.btnSQLRead.Size = new System.Drawing.Size(100, 39);
            this.btnSQLRead.TabIndex = 14;
            this.btnSQLRead.Text = "Read test";
            this.btnSQLRead.UseVisualStyleBackColor = true;
            this.btnSQLRead.Click += new System.EventHandler(this.btnSQLRead_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Records to test:";
            // 
            // btnSQLInsert
            // 
            this.btnSQLInsert.Location = new System.Drawing.Point(18, 92);
            this.btnSQLInsert.Name = "btnSQLInsert";
            this.btnSQLInsert.Size = new System.Drawing.Size(100, 39);
            this.btnSQLInsert.TabIndex = 13;
            this.btnSQLInsert.Text = "Insert Test";
            this.btnSQLInsert.UseVisualStyleBackColor = true;
            this.btnSQLInsert.Click += new System.EventHandler(this.btnSQLInsert_Click);
            // 
            // txtSQLConnString
            // 
            this.txtSQLConnString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSQLConnString.Location = new System.Drawing.Point(115, 29);
            this.txtSQLConnString.Name = "txtSQLConnString";
            this.txtSQLConnString.Size = new System.Drawing.Size(419, 20);
            this.txtSQLConnString.TabIndex = 8;
            // 
            // txtSQLResults
            // 
            this.txtSQLResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSQLResults.Location = new System.Drawing.Point(15, 164);
            this.txtSQLResults.Multiline = true;
            this.txtSQLResults.Name = "txtSQLResults";
            this.txtSQLResults.ReadOnly = true;
            this.txtSQLResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSQLResults.Size = new System.Drawing.Size(519, 314);
            this.txtSQLResults.TabIndex = 12;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1016, 496);
            this.splitContainer1.SplitterDistance = 456;
            this.splitContainer1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 542);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Azure Cosmos DB vs SQL Azure";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosmosDocumentCount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSQLRecordsCount)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCosmosDelete;
        private System.Windows.Forms.Button btnCosmosRead;
        private System.Windows.Forms.Button btnCosmosInsert;
        private System.Windows.Forms.TextBox txtCosmosResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudCosmosDocumentCount;
        private System.Windows.Forms.TextBox txtCosmosAuthToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCosmosEndpoint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSQLDelete;
        private System.Windows.Forms.Button btnSQLRead;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSQLInsert;
        private System.Windows.Forms.TextBox txtSQLConnString;
        private System.Windows.Forms.TextBox txtSQLResults;
        private System.Windows.Forms.NumericUpDown nudSQLRecordsCount;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnCosmosStaggered;
        private System.Windows.Forms.Button btnSQLStaggered;
        private System.Windows.Forms.Button btnSQLResultsClear;
        private System.Windows.Forms.Button btnCosmosResultsClear;
        private System.Windows.Forms.Button btnGraphInsert;
        private System.Windows.Forms.Button btnGraphTraverse;
        private System.Windows.Forms.Button btnGraphDrop;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}


namespace FiOT_AnalyzerUnitTest
{
    partial class ShowSavedData
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ReadyForRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponseDefined = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestDefined = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReadyForResponse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReadyForData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDefined = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifferentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnImportXml = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnExportXml = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 556);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnImportXml);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.btnExportXml);
            this.panel2.Location = new System.Drawing.Point(12, 574);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 30);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReadyForRequest,
            this.ResponseDefined,
            this.RequestDefined,
            this.ReadyForResponse,
            this.ReadyForData,
            this.DataDefined,
            this.TimeStamp,
            this.DifferentTime,
            this.State});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(934, 556);
            this.dataGridView2.TabIndex = 8;
            // 
            // ReadyForRequest
            // 
            this.ReadyForRequest.HeaderText = "ReadyForRequest";
            this.ReadyForRequest.Name = "ReadyForRequest";
            // 
            // ResponseDefined
            // 
            this.ResponseDefined.HeaderText = "ResponseDefined";
            this.ResponseDefined.Name = "ResponseDefined";
            // 
            // RequestDefined
            // 
            this.RequestDefined.HeaderText = "RequestDefined";
            this.RequestDefined.Name = "RequestDefined";
            // 
            // ReadyForResponse
            // 
            this.ReadyForResponse.HeaderText = "ReadyForResponse";
            this.ReadyForResponse.Name = "ReadyForResponse";
            // 
            // ReadyForData
            // 
            this.ReadyForData.HeaderText = "ReadyForData";
            this.ReadyForData.Name = "ReadyForData";
            // 
            // DataDefined
            // 
            this.DataDefined.HeaderText = "DataDefined";
            this.DataDefined.Name = "DataDefined";
            // 
            // TimeStamp
            // 
            this.TimeStamp.HeaderText = "TimeStamp";
            this.TimeStamp.Name = "TimeStamp";
            // 
            // DifferentTime
            // 
            this.DifferentTime.HeaderText = "DifferentTime";
            this.DifferentTime.Name = "DifferentTime";
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.Items.AddRange(new object[] {
            "OK",
            "NG",
            "UNKNOW"});
            this.State.Name = "State";
            this.State.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.State.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnImportXml
            // 
            this.btnImportXml.BackColor = System.Drawing.SystemColors.Info;
            this.btnImportXml.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImportXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportXml.Location = new System.Drawing.Point(118, 0);
            this.btnImportXml.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportXml.Name = "btnImportXml";
            this.btnImportXml.Size = new System.Drawing.Size(112, 30);
            this.btnImportXml.TabIndex = 5;
            this.btnImportXml.Text = "Nacist...";
            this.btnImportXml.UseVisualStyleBackColor = false;
            this.btnImportXml.Click += new System.EventHandler(this.btnImportXml_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(112, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 30);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // btnExportXml
            // 
            this.btnExportXml.BackColor = System.Drawing.SystemColors.Info;
            this.btnExportXml.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExportXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportXml.Location = new System.Drawing.Point(0, 0);
            this.btnExportXml.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportXml.Name = "btnExportXml";
            this.btnExportXml.Size = new System.Drawing.Size(112, 30);
            this.btnExportXml.TabIndex = 3;
            this.btnExportXml.Text = "Ulozit...";
            this.btnExportXml.UseVisualStyleBackColor = false;
            this.btnExportXml.Click += new System.EventHandler(this.btnExportXml_Click);
            // 
            // ShowSavedData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ShowSavedData";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Saved Data";
            this.Load += new System.EventHandler(this.ShowSavedData_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReadyForRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResponseDefined;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestDefined;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReadyForResponse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReadyForData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDefined;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifferentTime;
        private System.Windows.Forms.DataGridViewComboBoxColumn State;
        private System.Windows.Forms.Button btnImportXml;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnExportXml;
    }
}
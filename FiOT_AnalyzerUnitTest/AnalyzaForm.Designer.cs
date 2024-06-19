namespace FiOT_AnalyzerUnitTest
{
    partial class AnalyzaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImportXml = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnExportXml = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 10);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(124, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 10);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(70, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(182, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1151, 171);
            this.dataGridView1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(9, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1155, 188);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(9, 215);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1155, 398);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zmeny flagu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnImportXml);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.btnExportXml);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(2, 371);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1151, 25);
            this.panel2.TabIndex = 1;
            // 
            // btnImportXml
            // 
            this.btnImportXml.BackColor = System.Drawing.SystemColors.Info;
            this.btnImportXml.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImportXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportXml.Location = new System.Drawing.Point(118, 0);
            this.btnImportXml.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportXml.Name = "btnImportXml";
            this.btnImportXml.Size = new System.Drawing.Size(112, 25);
            this.btnImportXml.TabIndex = 2;
            this.btnImportXml.Text = "Nacist...";
            this.btnImportXml.UseVisualStyleBackColor = false;
            this.btnImportXml.Click += new System.EventHandler(this.btnImportXml_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(112, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 25);
            this.splitter1.TabIndex = 1;
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
            this.btnExportXml.Size = new System.Drawing.Size(112, 25);
            this.btnExportXml.TabIndex = 0;
            this.btnExportXml.Text = "Ulozit...";
            this.btnExportXml.UseVisualStyleBackColor = false;
            this.btnExportXml.Click += new System.EventHandler(this.btnExportXml_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(5, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 349);
            this.panel1.TabIndex = 0;
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
            this.dataGridView2.Size = new System.Drawing.Size(1148, 349);
            this.dataGridView2.TabIndex = 7;
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
            // AnalyzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1173, 623);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AnalyzaForm";
            this.ShowIcon = false;
            this.Text = "Analyza";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnImportXml;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnExportXml;
        private System.Windows.Forms.Panel panel1;
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
    }
}
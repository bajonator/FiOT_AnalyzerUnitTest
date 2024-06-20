using FiOT_AnalyzerUnitTest.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiOT_AnalyzerUnitTest
{
    public partial class MainForm : Form
    {
        string path;
        DataTable _dataTable;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            FileHelper fileHelper = new FileHelper();

            path = fileHelper.GetFileName();

            if (!string.IsNullOrEmpty(path))
            {
                tbFileSelected.Text = path;

                InitDataTable();
                PrepareData();
                PopulateDataToDatagrid();
            }
        }

        private void PopulateDataToDatagrid()
        {
            dataGridView1.DataSource = _dataTable;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dataGridView1.Columns[3].Visible = false;
        }

        private void PrepareData()
        {
            if (!string.IsNullOrEmpty(path))
            {
                var data = File.ReadAllLines(path);
                if (data != null && data.Length > 0)
                {
                    GenerateRowsToTable(data);
                }
            }
        }

        private void GenerateRowsToTable(string[] data)
        {
            string header = data[0].ToString();
            if (header.Contains(';'))
            {
                foreach (var row in data.Skip(1))
                {
                    string[] lineSplit = row.Split(';');
                    if (lineSplit.Length > 3)
                    {
                        string[] newLineSplit = new string[] { lineSplit[0], lineSplit[1] + lineSplit[2], lineSplit[3] };
                        _dataTable.Rows.Add(newLineSplit);
                    }
                }
            }
            else
            {
                foreach (var row in data.Skip(1))
                {
                    string[] lineSplit = row.Split(',');
                    if (lineSplit.Length < 4)
                    {
                        _dataTable.Rows.Add(lineSplit);
                    }
                }
            }
        }

        private void InitDataTable()
        {
            _dataTable = new DataTable();
            _dataTable.Columns.Add("Timestamp");
            _dataTable.Columns.Add("Node");
            _dataTable.Columns.Add("Value");
            //_dataTable.Columns.Add("Initial_Value");
            //_dataTable.Columns.Add("Change");
            _dataTable.Columns.Add("Time_Diff");
        }

        private void btnAnalyza_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                AnalyzaForm analyzaForm = new AnalyzaForm(_dataTable);
                analyzaForm.Show();
            }
            else
                MessageBox.Show("Nejsou zadne data pro zobrazeni analyzy");
        }

        private void btnLoadSavedData_Click(object sender, EventArgs e)
        {
            if (File.Exists(Program.FilePath))
            {
                ShowSavedData showSavedData = new ShowSavedData();
                showSavedData.Show();
            }
            else
                MessageBox.Show("Data nebyly ulozene");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
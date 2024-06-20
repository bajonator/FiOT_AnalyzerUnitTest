using FiOT_AnalyzerUnitTest.Extensions;
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
using System.Windows.Forms.VisualStyles;

namespace FiOT_AnalyzerUnitTest
{
    public partial class AnalyzaForm : Form
    {

        private SettingsDataHelper<List<DataModel>> _fileHelper = new SettingsDataHelper<List<DataModel>>(Program.FilePath);

        private DataTable _dataTable;
        HashSet<string> _flagsType1 = new HashSet<string> { "ReadyForRequest", "ResponseDefined", "RequestDefined", "ReadyForResponse", "Id" };
        HashSet<string> _flagsType2 = new HashSet<string> { "ReadyForData", "DataDefined" };

        private string _readyForRequest = "";
        private string _responseDefined = "";
        private string _requestDefined = "";
        private string _readyForResponse = "";
        private string _readyForData = "";
        private string _dataDefined = "";
        private string _timeStamp = "";
        private string _timeDifference = "";

        private PrepareDataFor _prepareDataFor;

        public AnalyzaForm(DataTable dataTable)
        {
            InitializeComponent();

            _prepareDataFor = new PrepareDataFor();
            dataGridView2.CellValueChanged -= dataGridView2_CellValueChanged;
            _dataTable = dataTable;

            PrepareDataGrid();
            GetData(_dataTable);
            DgvSetColumnSize();
            ChangeValueFromSpecificVarialble();

            dataGridView2.CellValueChanged += dataGridView2_CellValueChanged;
        }


        /// <summary>
        /// Obsluha události pro změny hodnoty buňky v dataGridView2. Aktualizuje barvu řádku na základě nové hodnoty buňky.
        /// </summary>
        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var colVal = dataGridView2.SelectedRows[0].Cells[e.ColumnIndex].Value as string;
            _prepareDataFor.SetRowColor(colVal, e.RowIndex, dataGridView2);
        }


        /// <summary>
        /// Nastaví velikost sloupců pro dataGridView1. Každý sloupec je nastaven na automatickou velikost a zarovnán na střed.
        /// </summary>
        private void DgvSetColumnSize()
        {
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        /// <summary>
        /// Připraví dataGridView1 přidáním sloupců pro Timestamp, Node, Value a Time Difference.
        /// </summary>
        private void PrepareDataGrid()
        {
            dataGridView1.Columns.Add("Timestamp", "Timestamp");
            dataGridView1.Columns.Add("Node", "Node");
            dataGridView1.Columns.Add("Value", "Value");
            dataGridView1.Columns.Add("Time_Diff", "Time Difference");
        }


        /// <summary>
        /// Získává data z DataTable, třídí je podle Timestamp a přidává do dataGridView1.
        /// </summary>
        /// <param name="datable">DataTable obsahující data k zobrazení</param>
        private void GetData(DataTable datable)
        {
            DataRow[] sortedRows = datable.Select("", "Timestamp ASC");

            DateTime? previousTimestamp = null;
            string previousValue = null;

            foreach (DataRow row in sortedRows)
            {
                if (!string.IsNullOrEmpty(row["Timestamp"].ToString()))
                {
                    DateTime timestamp = Convert.ToDateTime(row["Timestamp"]);
                    string value = row["Value"].ToString();

                    TimeSpan timeDiff = previousTimestamp.HasValue ? timestamp - previousTimestamp.Value : TimeSpan.Zero;
                    AddDataToDataGridView(row, timeDiff);

                    previousTimestamp = timestamp;
                    previousValue = value;
                }
            }
        }


        /// <summary>
        /// Přidává data do dataGridView1 s vypočítaným časovým rozdílem a nastavuje barvu textu podle typu vlajky.
        /// </summary>
        /// <param name="row">DataRow obsahující data k přidání</param>
        /// <param name="timeDiff">Časový rozdíl mezi aktuálním a předchozím záznamem</param>
        private void AddDataToDataGridView(DataRow row, TimeSpan timeDiff)
        {
            var value = row["Value"].ToString() == "True" ? 1 : 0;
            var items = row.ItemArray.Select(r => r.ToString());
            string formattedTimeDiff = $"{timeDiff.Hours:00}:{timeDiff.Minutes:00}:{timeDiff.Seconds:00}.{timeDiff.Milliseconds:00}";
            if (items.Any(item => _flagsType1.Any(flag => item.Contains(flag))))
            {
                int index = dataGridView1.Rows.Add(row["Timestamp"], row["Node"], value, formattedTimeDiff);
                dataGridView1.Rows[index].DefaultCellStyle.ForeColor = Color.RoyalBlue;
            }
            else if (items.Any(item => _flagsType2.Any(flag => item.Contains(flag))))
            {
                int index = dataGridView1.Rows.Add(row["Timestamp"], row["Node"], value, formattedTimeDiff);
                dataGridView1.Rows[index].DefaultCellStyle.ForeColor = Color.Red;
            }
        }


        /// <summary>
        /// Mění hodnoty specifických proměnných a přidává nové řádky do dataGridView2 na základě nalezených proměnných.
        /// </summary>
        private void ChangeValueFromSpecificVarialble()
        {
            dataGridView2.Rows.Clear();
            var model = new Dictionary<string, string>();
            model.Add("ReadyForRequest", "1");
            model.Add("ResponseDefined", "0");
            model.Add("RequestDefined", "0");
            model.Add("ReadyForResponse", "0");
            model.Add("ReadyForData", "1");
            model.Add("DataDefined", "0");

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var items = new List<string>();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        items.Add(cell.Value.ToString());
                    }
                }
                if (items.Count > 0)
                {
                    _timeStamp = items[0];
                    _timeDifference = items[3];
                }

                FindVariableName(items);
            }
        }


        /// <summary>
        /// Najde název proměnné v seznamu položek a přidá odpovídající řádky do dataGridView2.
        /// </summary>
        /// <param name="items">Seznam položek prohledávaných pro název proměnné</param>
        private void FindVariableName(List<string> items)
        {
            foreach (var item in items)
            {
                var newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView2);
                newRow.Cells[0].Value = _readyForRequest;
                newRow.Cells[1].Value = _responseDefined;
                newRow.Cells[2].Value = _requestDefined;
                newRow.Cells[3].Value = _readyForResponse;
                newRow.Cells[4].Value = _readyForData;
                newRow.Cells[5].Value = _dataDefined;
                newRow.Cells[6].Value = _timeStamp;
                newRow.Cells[7].Value = _timeDifference;



                if (item.Contains("ReadyForRequest"))
                {
                    _readyForRequest = items[2];
                    newRow.Cells[0].Value = _readyForRequest;
                    newRow.Cells[0].Style.BackColor = Color.RoyalBlue;
                    dataGridView2.Rows.Add(newRow);
                }
                if (item.Contains("ResponseDefined"))
                {
                    _responseDefined = items[2];
                    newRow.Cells[1].Value = _responseDefined;
                    newRow.Cells[1].Style.BackColor = Color.RoyalBlue;
                    dataGridView2.Rows.Add(newRow);

                }
                if (item.Contains("RequestDefined"))
                {
                    _requestDefined = items[2];
                    newRow.Cells[2].Value = _requestDefined;
                    newRow.Cells[2].Style.BackColor = Color.RoyalBlue;
                    dataGridView2.Rows.Add(newRow);
                }
                if (item.Contains("ReadyForResponse"))
                {
                    _readyForResponse = items[2];
                    newRow.Cells[3].Value = _readyForResponse;
                    newRow.Cells[3].Style.BackColor = Color.RoyalBlue;
                    dataGridView2.Rows.Add(newRow);

                }
                if (item.Contains("ReadyForData"))
                {
                    _readyForData = items[2];
                    newRow.Cells[4].Value = _readyForData;
                    newRow.Cells[4].Style.BackColor = Color.RoyalBlue;
                    dataGridView2.Rows.Add(newRow);
                }
                if (item.Contains("DataDefined"))
                {
                    _dataDefined = items[2];
                    newRow.Cells[5].Value = _dataDefined;
                    newRow.Cells[5].Style.BackColor = Color.RoyalBlue;
                    dataGridView2.Rows.Add(newRow);
                }
                if (_readyForRequest == "1" && _responseDefined == "0" && _requestDefined == "0" && _readyForResponse == "0" && _readyForData == "1" && _dataDefined == "0")
                {
                    newRow.DefaultCellStyle.ForeColor = Color.DarkViolet;
                }
            }
        }

        /// <summary>
        /// Obsluha události pro export dat z dataGridView2 do souboru xml.
        /// </summary>
        private void btnExportXml_Click(object sender, EventArgs e)
        {
            _prepareDataFor.ExportDataToXML(dataGridView2);
        }


        /// <summary>
        /// Obsluha události pro import dat ze souboru xml do dataGridView2.
        /// </summary>
        private void btnImportXml_Click(object sender, EventArgs e)
        {

            _prepareDataFor.LoadAndPopulateDataGridView(dataGridView2);
        }

        private void AnalyzaForm_Load(object sender, EventArgs e)
        {
            dataGridView2.ClearSelection();
            dataGridView2.CurrentCell = null;
        }
    }
}
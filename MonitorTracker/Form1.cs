using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HtmlAgilityPack;

namespace MonitorTracker
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    public partial class Form1 : Form
    {
        private const string MONITOR_SEARCH_URL = "http://drs.sbc.com/DRS/sqlread.asp?RANDID=ch29387172007103004&R1=";
        private const string PC_SEARCH_START_URL = "http://drs.sbc.com/drs/index.asp?MPASSETQUERY=";
        private const string PC_SEARCH_END_URL = "&MPASSETTYPE=SERIAL_NUMBER&MPQUERYLOGIC=LIKE";
        private const string DRS_URL = "drs.sbc.com";

        private string _serialNumber;
        private string _pcSerial;

        public Form1()
        {
            InitializeComponent();

            if (!IsNetworkAvailable())
            {
                DisableControls(this);


                var no = new NoNetworkPrompt();

                // pop up the form 
                no.TopMost = true;
                no.Show();

            }


        }

        private void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                DisableControls(c);
            }
            con.Enabled = false;
        }

        private void EnableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                DisableControls(c);
            }
            con.Enabled = true;
        }

        private bool IsNetworkAvailable()
        {
            string host = DRS_URL;
            bool result = false;
            Ping p = new Ping();
            
            try
            {
                PingReply reply = p.Send(host, 3000);
                if (reply.Status == IPStatus.Success)
                    return true;
            }
            catch { }
            
            return result;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            ClearResults();

            if(String.IsNullOrEmpty(textOldSerial.Text))
            {
                labelError.Text = "Serial number cannot be empty.";
                textOldSerial.Focus();
                return;
            }
         
            ParseSerialNumber(textOldSerial.Text);
        }

        private void ClearResults()
        {
            labelError.Text = "";
            textNewSerial.Text = "";
            linkPc.Text = "";
            labelSeen.Text = "";
            labelFetching.Text = "";
        }

        private void ParseSerialNumber(string serialNumber)
        {
            char[] serial = serialNumber.ToCharArray();

            // check for correct 20 char length
            if (serial.Length < 20 || serial.Length > 20)
            {
                labelError.Text = "Serial number must be at least 20 characters";
                textOldSerial.Focus();

                return;
            }
                
            var newSerial = new StringBuilder();

            for (int i = 0; i < serial.Length; i++)
            {
                if( (i > 2 && i < 8) || (i > 12))
                {
                    newSerial.Append(serial[i]);
                }
            }

            _serialNumber = newSerial.ToString();
            textNewSerial.Text = _serialNumber;

            labelFetching.Text = "Starting record search ...";

            FetchRecord(MONITOR_SEARCH_URL + newSerial);
        }

        private void FetchRecord(string url)
        {
            // fetch url
            var wb = new WebBrowser();
            
            try
            {
                wb.Navigate(new Uri(url));
            }
            catch (UriFormatException)
            {

                return;
            }      

            // set navigating and navigater methods
            wb.Navigating += wb_Navigating;
            wb.Navigated += wb_Navigated;
            wb.DocumentCompleted += wb_DocumentCompleted;
        }

        private void wb_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            //labelFetching.Text = "Starting record search ...";
        }

        private void wb_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            labelFetching.Text = "Parsing records ...";
        }

        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            labelFetching.Text = "Finished ...";
            ProcessContent((WebBrowser)sender);
        }

        private void ProcessContent(WebBrowser content = null)
        {
            // load html document
            var html = new HtmlAgilityPack.HtmlDocument();
            html.Load(content.DocumentStream);
            //html.Load("monitors.html");

            // get table with id named main_tbl
            var mainTable = html.DocumentNode.SelectNodes("//table[@id='main_tbl']/tr/td");

            if (mainTable != null)
            {
                var dataTable = new DataTable();

                //get titles
                for (int i = 0; i <= 8; i++)
                {
                    dataTable.Columns.Add(mainTable[i].InnerText);
                }

                for (int i = 9; i < mainTable.Count(); i++)
                {
                    // start of new row
                    if (i % 9 == 0)
                    {
                        // only add the row that corresponds to the correct serial number
                        // if MON_SER_NUM == _serialNumber
                        // add the next 9 fields to table that make up a row
                        if (mainTable[i + 3].InnerText == _serialNumber)
                        {
                            dataTable.Rows.Add(mainTable[i].InnerText, mainTable[i + 1].InnerText, mainTable[i + 2].InnerText, mainTable[i + 3].InnerText, mainTable[i + 4].InnerText, mainTable[i + 5].InnerText, mainTable[i + 6].InnerText, mainTable[i + 7].InnerText, mainTable[i + 8].InnerText);
                        }

                    }

                }

                // filter most likely pc
                _pcSerial = dataTable.Rows[0][7].ToString();
                var lastSeen = dataTable.Rows[0][8].ToString();

                

                if (!String.IsNullOrEmpty(_pcSerial))
                {
                    linkPc.Text = _pcSerial;
                    labelSeen.Text = lastSeen;

                    linkPc.LinkClicked +=linkPc_LinkClicked;

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.ScrollBars = ScrollBars.Both;
                } else
                {
                    linkPc.Text = "No known monitor.";
                }

            }
        }

        private void linkPc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(PC_SEARCH_START_URL + _pcSerial + PC_SEARCH_END_URL);
            Process.Start(sInfo);
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textNewSerial.Text))
            {
                Clipboard.SetText(textNewSerial.Text);
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}

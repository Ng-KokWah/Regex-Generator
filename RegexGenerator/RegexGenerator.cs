using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexGenerator
{
    public partial class RegexGenerator : Form
    {
        public RegexGenerator()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private static String type = "";
        private void btnGen_Click(object sender, EventArgs e)
        {

            List<String> regexOutput = new List<String>();
            if (type == "Explicit")
            {
                regexOutput = RegexComputation.generateExplicitRegex(tbInput.Text);
            }
            else if(type == "Pattern")
            {
                regexOutput = RegexComputation.generatePatternRegex(tbInput.Text);
            }
            else
            {
                regexOutput = RegexComputation.generateRangeRegex(tbInput.Text);
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Regex");
            dt.Columns.Add("Worked");

            if (type == "Pattern")
            {
                foreach (String n in regexOutput)
                {
                    Console.WriteLine(n);
                    dt.Rows.Add(n, "Click Here To Test The Regex!");
                }
            }
            else
            {
                foreach (String n in regexOutput)
                {
                    Console.WriteLine(n);
                    dt.Rows.Add(n, Convert.ToString(RegexComputation.checkRegexWorks(n, tbInput.Text)));
                }
            }

            dgvOutput.DataSource = dt;
        }

        private void rbExplicitMatch_CheckedChanged(object sender, EventArgs e)
        {
            type = "Explicit";
        }

        private void rbPattern_CheckedChanged(object sender, EventArgs e)
        {
            type = "Pattern";
        }

        private void rbRange_CheckedChanged(object sender, EventArgs e)
        {
            type = "Range";
        }

        private void btnRangeSample_Click(object sender, EventArgs e)
        {
            rbRange.Checked = true;

            Random r = new Random();
            switch(r.Next(0, 6))
            {
                case 0:
                    tbInput.Text = "abcdefghijklmnopqrstuvwxyz";
                    break;
                case 1:
                    tbInput.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    break;
                case 2:
                    tbInput.Text = "0123456789";
                    break;
                case 3:
                    tbInput.Text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    break;
                case 4:
                    tbInput.Text = "abcdefghijklmnopqrstuvwxyz0123456789";
                    break;
                case 5:
                    tbInput.Text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                    break;
            }
        }

        private void btnExplicitSample_Click(object sender, EventArgs e)
        {
            rbExplicitMatch.Checked = true;

            Random r = new Random();
            switch (r.Next(0, 3))
            {
                case 0:
                    tbInput.Text = "akjasdkjhk";
                    break;
                case 1:
                    tbInput.Text = "djnasjkdaskjdan";
                    break;
                case 2:
                    tbInput.Text = "k2b3jkb2k3j1";
                    break;
                case 3:
                    tbInput.Text = "jasd231412kjqe";
                    break;
            }
        }

        private void btnPatternSample_Click(object sender, EventArgs e)
        {
            rbPattern.Checked = true;

            Random r = new Random();
            switch (r.Next(0, 3))
            {
                case 0:
                    tbInput.Text = "S|num:7|upperalpha";
                    tbSampleLabel.Text = "SG NRIC E.g. S12345678G";
                    break;
                case 1:
                    tbInput.Text = "loweralpha:+|@|loweralpha:+|.|loweralpha:+";
                    tbSampleLabel.Text = "Email E.g. test@test.com";
                    break;
                case 2:
                    tbInput.Text = "+|num|num|num:8";
                    tbSampleLabel.Text = "SG Phone Number E.g. +6591234234";
                    break;
                case 3:
                    tbInput.Text = "0,1,2|num|0,1,2,3,4,5|num";
                    tbSampleLabel.Text = "Time E.g. 2359";
                    break;
            }
        }

        private void dgvOutput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (type == "Pattern")
            {
                try
                {
                    String reg = "";
                    if (dgvOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        reg = Convert.ToString(dgvOutput.Rows[e.RowIndex].Cells[0].Value);
                    }

                    TestPatternRegex next = new TestPatternRegex();
                    next.setRegex(reg);
                    next.Show();

                }
                catch (ArgumentOutOfRangeException error)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }
    }
}

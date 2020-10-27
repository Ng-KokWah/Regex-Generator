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
    public partial class TestPatternRegex : Form
    {
        public TestPatternRegex()
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

        private static String regularExp = "";

        public String getRegex ()
        {
            return regularExp;
        }

        public void setRegex(String reg)
        {
            regularExp = reg;
        }

        private void TestPatternRegex_Load(object sender, EventArgs e)
        {
            tbRegex.Text = regularExp;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbTestString.Text) || String.IsNullOrWhiteSpace(tbTestString.Text))
            {
                MessageBox.Show("String To Test Cannot Be Empty!");
            }
            else
            {
                Boolean pass = RegexComputation.checkRegexWorks(regularExp, tbTestString.Text);
                if(pass == true)
                {
                    btnShowPassed.BackColor = Color.Green;
                    btnShowPassed.Text = "Passed";
                }
                else
                {
                    btnShowPassed.BackColor = Color.Red;
                    btnShowPassed.Text = "Failed";
                }
            }
        }
    }
}

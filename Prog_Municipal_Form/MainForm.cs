using System;
using System.Windows.Forms;

namespace Prog_Municipal_Form
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ApplyTheme();
        }
        // --------------------------------------------Background/Buttons Colour---------------------------------------------------------
        private void ApplyTheme()
        {
            this.BackColor = System.Drawing.Color.FromArgb(240, 244, 248); 

            btnReportIssues.BackColor = System.Drawing.Color.Teal;
            btnReportIssues.ForeColor = System.Drawing.Color.White;

            btnEvents.BackColor = System.Drawing.Color.FromArgb(176, 190, 197); 
            btnEvents.ForeColor = System.Drawing.Color.White;
            btnEvents.Enabled = false;

            btnStatus.BackColor = System.Drawing.Color.FromArgb(176, 190, 197);
            btnStatus.ForeColor = System.Drawing.Color.White;
            btnStatus.Enabled = false;

            this.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Regular);
        }


        private void btnReportIssues_Click(object sender, EventArgs e)
        {
           
            ReportIssueForm reportForm = new ReportIssueForm(this);
            this.Hide(); 
            reportForm.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
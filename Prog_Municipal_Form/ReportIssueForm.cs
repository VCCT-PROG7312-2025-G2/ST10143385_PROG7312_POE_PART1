using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prog_Municipal_Form
{
    public partial class ReportIssueForm : Form
    {
 
        private static LinkedList<Issue> reportedIssues = new LinkedList<Issue>();
        private string attachmentPath = "";
        private MainForm _mainForm;

        public ReportIssueForm(MainForm mainForm)
        {
            InitializeComponent();
            ApplyTheme();
            _mainForm = mainForm;
        }

        // ---------------------------------Form Background & Button Colours---------------------------------------

        private void ApplyTheme()
        {
      
            this.BackColor = System.Drawing.Color.FromArgb(240, 244, 248);

           
            lblAttachment.ForeColor = System.Drawing.Color.DarkSlateGray;
 
            btnAttach.BackColor = System.Drawing.Color.Teal;
            btnAttach.ForeColor = System.Drawing.Color.White;

            btnSubmit.BackColor = System.Drawing.Color.Teal;
            btnSubmit.ForeColor = System.Drawing.Color.White;

            btnBack.BackColor = System.Drawing.Color.Teal;
            btnBack.ForeColor = System.Drawing.Color.White;

            txtLocation.BackColor = System.Drawing.Color.White;
            cmbCategory.BackColor = System.Drawing.Color.White;
            rtbDescription.BackColor = System.Drawing.Color.White;

            progressBarSubmit.Visible = false;
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images|*.jpg;*.png;*.jpeg|Documents|*.pdf;*.docx|All Files|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                attachmentPath = dialog.FileName;
                lblAttachment.Text = "Attached: " + attachmentPath;
            }
        }
    
        // -------------------------------- Error Checking + Progress Bar ---------------------------------
        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter the location of the issue.",
                                "Missing Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category for the issue.",
                                "Missing Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show("Please provide a description of the issue.",
                                "Missing Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(attachmentPath))
            {
                DialogResult result = MessageBox.Show(
                    "You have not attached any file. Do you want to continue without an attachment?",
                    "No Attachment",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            progressBarSubmit.Visible = true;
            progressBarSubmit.Value = 0;

            for (int i = 0; i <= 100; i += 20)
            {
                progressBarSubmit.Value = i;
                await System.Threading.Tasks.Task.Delay(200); 
            }

      
            Issue newIssue = new Issue
            {
                Location = txtLocation.Text.Trim(),
                Category = cmbCategory.SelectedItem.ToString(),
                Description = rtbDescription.Text.Trim(),
                AttachmentPath = attachmentPath
            };
            
            // -----------------------------------Add to the Linked List -------------------------------------
            reportedIssues.AddLast(newIssue);

            MessageBox.Show("Your issue has been submitted successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);


            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            rtbDescription.Clear();
            lblAttachment.Text = "No file attached";
            attachmentPath = null;
            progressBarSubmit.Visible = false;
        }

        // --------------------------------Back Button (show MainForm again)---------------------------------
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            _mainForm.Show();
            this.Dispose();
        }

        private void ReportIssueForm_Load(object sender, EventArgs e) { }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
    }
}

namespace Prog_Municipal_Form
{
    partial class ReportIssueForm
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
        /// 

        // ----------------------------------------------Table Layout Report Form-------------------------------------------------------
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.panelAttachment = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAttach = new System.Windows.Forms.Button();
            this.lblAttachmentPath = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.progressBarSubmit = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelAttachment.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.lblLocation, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLocation, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCategory, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbCategory, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rtbDescription, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAttachment, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panelAttachment, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panelButtons, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(3, 13);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(51, 13);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLocation.Location = new System.Drawing.Point(243, 10);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(554, 20);
            this.txtLocation.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(3, 53);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Sanitation",
            "Roads",
            "Utilities",
            "Water Supply",
            "Electricity",
            "Waste Management",
            "Public Parks",
            "Building Maintenance",
            "Other"});
            this.cmbCategory.Location = new System.Drawing.Point(243, 43);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(554, 21);
            this.cmbCategory.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 208);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDescription.Location = new System.Drawing.Point(243, 83);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(554, 264);
            this.rtbDescription.TabIndex = 5;
            this.rtbDescription.Text = "";
            // 
            // lblAttachment
            // 
            this.lblAttachment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.Location = new System.Drawing.Point(3, 368);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(64, 13);
            this.lblAttachment.TabIndex = 6;
            this.lblAttachment.Text = "Attachment:";
            // 
            // panelAttachment
            // 
            this.panelAttachment.Controls.Add(this.btnAttach);
            this.panelAttachment.Controls.Add(this.lblAttachmentPath);
            this.panelAttachment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAttachment.Location = new System.Drawing.Point(243, 353);
            this.panelAttachment.Name = "panelAttachment";
            this.panelAttachment.Size = new System.Drawing.Size(554, 44);
            this.panelAttachment.TabIndex = 7;
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(3, 10);
            this.btnAttach.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(100, 23);
            this.btnAttach.TabIndex = 0;
            this.btnAttach.Text = "Attach File";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // lblAttachmentPath
            // 
            this.lblAttachmentPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAttachmentPath.AutoSize = true;
            this.lblAttachmentPath.Location = new System.Drawing.Point(109, 16);
            this.lblAttachmentPath.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblAttachmentPath.Name = "lblAttachmentPath";
            this.lblAttachmentPath.Size = new System.Drawing.Size(91, 13);
            this.lblAttachmentPath.TabIndex = 1;
            this.lblAttachmentPath.Text = "No file attached...";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnBack);
            this.panelButtons.Controls.Add(this.btnSubmit);
            this.panelButtons.Controls.Add(this.progressBarSubmit);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelButtons.Location = new System.Drawing.Point(243, 403);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(554, 44);
            this.panelButtons.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(476, 10);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(395, 10);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // progressBarSubmit
            // 
            this.progressBarSubmit.Location = new System.Drawing.Point(109, 10);
            this.progressBarSubmit.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.progressBarSubmit.Name = "progressBarSubmit";
            this.progressBarSubmit.Size = new System.Drawing.Size(280, 23);
            this.progressBarSubmit.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarSubmit.TabIndex = 2;
            this.progressBarSubmit.Visible = false;
            // 
            // ReportIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReportIssueForm";
            this.Text = "Report Issue";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelAttachment.ResumeLayout(false);
            this.panelAttachment.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.FlowLayoutPanel panelAttachment;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Label lblAttachmentPath;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ProgressBar progressBarSubmit;
    }
}

namespace Prog_Municipal_Form
{
    partial class MainForm
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

        // -------------------------------------------Table Layout Main Menu----------------------------------------------------------

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // ------------------------------------------------------------------------

            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblHeading, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStatus, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnEvents, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnReportIssues, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);

            // ------------------------------------------------------------------------

            this.lblHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Navy;
            this.lblHeading.Location = new System.Drawing.Point(3, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(794, 105);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Welcome to the Municipality Report and Requests Form";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ---------------------------------Report Issues Button---------------------------------------

            this.btnReportIssues.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReportIssues.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReportIssues.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReportIssues.Location = new System.Drawing.Point(300, 206);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(200, 50);
            this.btnReportIssues.TabIndex = 1;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.UseVisualStyleBackColor = false;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);

            // ------------------------------------------------------------------------

            this.btnEvents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEvents.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEvents.Enabled = false;
            this.btnEvents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEvents.Location = new System.Drawing.Point(300, 290);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(200, 50);
            this.btnEvents.TabIndex = 2;
            this.btnEvents.Text = "Local Events";
            this.btnEvents.UseVisualStyleBackColor = false;

            // ------------------------------------------------------------------------

            this.btnStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStatus.BackColor = System.Drawing.Color.Gainsboro;
            this.btnStatus.Enabled = false;
            this.btnStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnStatus.Location = new System.Drawing.Point(300, 378);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(200, 50);
            this.btnStatus.TabIndex = 3;
            this.btnStatus.Text = "Service Request Status";
            this.btnStatus.UseVisualStyleBackColor = false;

            // ----------------------------------Image--------------------------------------

            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Prog_Municipal_Form.Properties.Resources.municipal_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(325, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;

            // ------------------------------------------------------------------------

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Municipality App";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


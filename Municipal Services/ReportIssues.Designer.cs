namespace Municipal_Services
{
    partial class ReportIssues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportIssues));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.Thankyou = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbLocation = new System.Windows.Forms.GroupBox();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ofdAttachments = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Thankyou)).BeginInit();
            this.gbLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.SubmitBtn);
            this.panel1.Controls.Add(this.Thankyou);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rtbDescription);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.gbLocation);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 883);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1057, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 54);
            this.btnExit.TabIndex = 15;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // backBtn
            // 
            this.backBtn.ForeColor = System.Drawing.Color.Yellow;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(12, 22);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(80, 54);
            this.backBtn.TabIndex = 14;
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(794, 636);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(247, 35);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SubmitBtn.Location = new System.Drawing.Point(242, 636);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(247, 35);
            this.SubmitBtn.TabIndex = 12;
            this.SubmitBtn.Text = "Submit Report";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // Thankyou
            // 
            this.Thankyou.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Thankyou.Image = ((System.Drawing.Image)(resources.GetObject("Thankyou.Image")));
            this.Thankyou.Location = new System.Drawing.Point(703, 546);
            this.Thankyou.Name = "Thankyou";
            this.Thankyou.Size = new System.Drawing.Size(115, 84);
            this.Thankyou.TabIndex = 11;
            this.Thankyou.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBrowse.Location = new System.Drawing.Point(428, 561);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(247, 35);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse Files";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Attach a File Regarding the Issue";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(143, 378);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbDescription.Size = new System.Drawing.Size(898, 162);
            this.rtbDescription.TabIndex = 7;
            this.rtbDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(139, 350);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(291, 20);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Provide a Detailed Description of the Issue";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(468, 301);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(303, 28);
            this.cmbCategory.TabIndex = 5;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(139, 304);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(283, 20);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Select the Category of the Reported Issue";
            // 
            // gbLocation
            // 
            this.gbLocation.Controls.Add(this.cmbProvince);
            this.gbLocation.Controls.Add(this.txtPostalCode);
            this.gbLocation.Controls.Add(this.txtCity);
            this.gbLocation.Controls.Add(this.txtSuburb);
            this.gbLocation.Controls.Add(this.txtStreetAddress);
            this.gbLocation.Controls.Add(this.lblPostalCode);
            this.gbLocation.Controls.Add(this.label4);
            this.gbLocation.Controls.Add(this.lblCity);
            this.gbLocation.Controls.Add(this.lblSuburb);
            this.gbLocation.Controls.Add(this.lblAddress);
            this.gbLocation.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLocation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbLocation.Location = new System.Drawing.Point(143, 99);
            this.gbLocation.Name = "gbLocation";
            this.gbLocation.Size = new System.Drawing.Size(972, 177);
            this.gbLocation.TabIndex = 3;
            this.gbLocation.TabStop = false;
            this.gbLocation.Text = "Issue Location Details";
            // 
            // cmbProvince
            // 
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Location = new System.Drawing.Point(728, 34);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(210, 31);
            this.cmbProvince.TabIndex = 10;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(728, 79);
            this.txtPostalCode.MaxLength = 4;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(110, 30);
            this.txtPostalCode.TabIndex = 9;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(155, 123);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(250, 30);
            this.txtCity.TabIndex = 7;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(155, 79);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(250, 30);
            this.txtSuburb.TabIndex = 6;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(155, 34);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(377, 30);
            this.txtStreetAddress.TabIndex = 5;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(541, 70);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(100, 23);
            this.lblPostalCode.TabIndex = 4;
            this.lblPostalCode.Text = "Postal Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Province";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(15, 123);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 23);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(15, 79);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(107, 23);
            this.lblSuburb.TabIndex = 1;
            this.lblSuburb.Text = "Suburb/Area";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(15, 37);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(119, 23);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Street Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(134, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(796, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Report Issues Found Within the Community";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(12, 136);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(116, 112);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(822, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 8);
            this.panel2.TabIndex = 0;
            // 
            // ofdAttachments
            // 
            this.ofdAttachments.FileName = "Select Attachments";
            this.ofdAttachments.Filter = "\"All Files|*.*|Images|*.jpg;*.jpeg;*.png;*.gif|Documents|*.pdf;*.doc;*.docx\"";
            // 
            // ReportIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 824);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReportIssues";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ReportIssues_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Thankyou)).EndInit();
            this.gbLocation.ResumeLayout(false);
            this.gbLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.GroupBox gbLocation;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox Thankyou;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.OpenFileDialog ofdAttachments;
    }
}
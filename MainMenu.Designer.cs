namespace Municipal_Services
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.topPanel = new System.Windows.Forms.Panel();
            this.FullPanel = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Nav_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.header_panel = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.ReportBtn = new System.Windows.Forms.Button();
            this.EventsBtn = new System.Windows.Forms.Button();
            this.StatusBtn = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.FullPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Nav_Panel.SuspendLayout();
            this.header_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.FullPanel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1834, 65535);
            this.topPanel.TabIndex = 0;
            // 
            // FullPanel
            // 
            this.FullPanel.Controls.Add(this.ExitBtn);
            this.FullPanel.Controls.Add(this.pictureBox1);
            this.FullPanel.Controls.Add(this.Nav_Panel);
            this.FullPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FullPanel.Location = new System.Drawing.Point(0, 0);
            this.FullPanel.Name = "FullPanel";
            this.FullPanel.Size = new System.Drawing.Size(1834, 65535);
            this.FullPanel.TabIndex = 0;
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(1537, 22);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 59);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(508, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1300, 1000);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Nav_Panel
            // 
            this.Nav_Panel.AutoSize = true;
            this.Nav_Panel.BackColor = System.Drawing.Color.SeaGreen;
            this.Nav_Panel.Controls.Add(this.header_panel);
            this.Nav_Panel.Controls.Add(this.ReportBtn);
            this.Nav_Panel.Controls.Add(this.EventsBtn);
            this.Nav_Panel.Controls.Add(this.StatusBtn);
            this.Nav_Panel.Controls.Add(this.label1);
            this.Nav_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Nav_Panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Nav_Panel.Location = new System.Drawing.Point(0, 0);
            this.Nav_Panel.Name = "Nav_Panel";
            this.Nav_Panel.Size = new System.Drawing.Size(505, 65535);
            this.Nav_Panel.TabIndex = 0;
            this.Nav_Panel.WrapContents = false;
            // 
            // header_panel
            // 
            this.header_panel.Controls.Add(this.Logo);
            this.header_panel.Location = new System.Drawing.Point(3, 3);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(273, 269);
            this.header_panel.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(200, 4, 4, 4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(282, 278);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // ReportBtn
            // 
            this.ReportBtn.AutoSize = true;
            this.ReportBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ReportBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightYellow;
            this.ReportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.ReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportBtn.Font = new System.Drawing.Font("Segoe UI", 12.8F);
            this.ReportBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ReportBtn.Image = ((System.Drawing.Image)(resources.GetObject("ReportBtn.Image")));
            this.ReportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportBtn.Location = new System.Drawing.Point(8, 285);
            this.ReportBtn.Margin = new System.Windows.Forms.Padding(8, 10, 7, 3);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(490, 75);
            this.ReportBtn.TabIndex = 1;
            this.ReportBtn.Text = "Report Issues and Request Services";
            this.ReportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReportBtn.UseVisualStyleBackColor = false;
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // EventsBtn
            // 
            this.EventsBtn.AutoSize = true;
            this.EventsBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.EventsBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightYellow;
            this.EventsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.EventsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventsBtn.Font = new System.Drawing.Font("Segoe UI", 12.8F);
            this.EventsBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.EventsBtn.Image = ((System.Drawing.Image)(resources.GetObject("EventsBtn.Image")));
            this.EventsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EventsBtn.Location = new System.Drawing.Point(8, 370);
            this.EventsBtn.Margin = new System.Windows.Forms.Padding(8, 7, 7, 3);
            this.EventsBtn.Name = "EventsBtn";
            this.EventsBtn.Size = new System.Drawing.Size(490, 75);
            this.EventsBtn.TabIndex = 2;
            this.EventsBtn.Text = "Events and Announcements";
            this.EventsBtn.UseVisualStyleBackColor = false;
            this.EventsBtn.Click += new System.EventHandler(this.EventsBtn_Click);
            // 
            // StatusBtn
            // 
            this.StatusBtn.AutoSize = true;
            this.StatusBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.StatusBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightYellow;
            this.StatusBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.StatusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusBtn.Font = new System.Drawing.Font("Segoe UI", 12.8F);
            this.StatusBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.StatusBtn.Image = ((System.Drawing.Image)(resources.GetObject("StatusBtn.Image")));
            this.StatusBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatusBtn.Location = new System.Drawing.Point(8, 455);
            this.StatusBtn.Margin = new System.Windows.Forms.Padding(8, 7, 7, 3);
            this.StatusBtn.Name = "StatusBtn";
            this.StatusBtn.Size = new System.Drawing.Size(490, 75);
            this.StatusBtn.TabIndex = 3;
            this.StatusBtn.Text = "Status of Service Request";
            this.StatusBtn.UseVisualStyleBackColor = false;
            this.StatusBtn.Click += new System.EventHandler(this.StatusBtn_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(30, 558);
            this.label1.Margin = new System.Windows.Forms.Padding(30, 25, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Feature: Events and Announcements !!!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1834, 1370);
            this.ControlBox = false;
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.topPanel.ResumeLayout(false);
            this.FullPanel.ResumeLayout(false);
            this.FullPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Nav_Panel.ResumeLayout(false);
            this.Nav_Panel.PerformLayout();
            this.header_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel FullPanel;
        private System.Windows.Forms.FlowLayoutPanel Nav_Panel;
        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button ReportBtn;
        private System.Windows.Forms.Button EventsBtn;
        private System.Windows.Forms.Button StatusBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label label1;
    }
}


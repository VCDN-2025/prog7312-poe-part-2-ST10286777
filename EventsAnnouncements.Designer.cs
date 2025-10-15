using System.Windows.Forms;

namespace Municipal_Services
{
    partial class EventsAnnouncements
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsAnnouncements));
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSortBy = new System.Windows.Forms.ComboBox();
            this.dgvLastViewed = new System.Windows.Forms.DataGridView();
            this.dgvRecommendations = new System.Windows.Forms.DataGridView();
            this.cmbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.lblResultsCount = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblSort = new System.Windows.Forms.Label();
            this.lblLastViewed = new System.Windows.Forms.Label();
            this.lblAllEvents = new System.Windows.Forms.Label();
            this.lblRecommendations = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.btnRefreshRecs = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCategoryFilter = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.panelEvents = new System.Windows.Forms.Panel();
            this.panelViewed = new System.Windows.Forms.Panel();
            this.panelRecs = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.lblAnalyticsTitle = new System.Windows.Forms.Label();
            this.lblMostPopularCategory = new System.Windows.Forms.Label();
            this.lblTotalSearches = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLastViewed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecommendations)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelEvents.SuspendLayout();
            this.panelViewed.SuspendLayout();
            this.panelRecs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.statsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEvents
            // 
            this.dgvEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvents.BackgroundColor = System.Drawing.Color.White;
            this.dgvEvents.ColumnHeadersHeight = 29;
            this.dgvEvents.Location = new System.Drawing.Point(15, 40);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.RowHeadersWidth = 51;
            this.dgvEvents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvEvents.Size = new System.Drawing.Size(1080, 300);
            this.dgvEvents.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(85, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(350, 30);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(872, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 34);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSortBy
            // 
            this.cmbSortBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSortBy.Location = new System.Drawing.Point(85, 52);
            this.cmbSortBy.Name = "cmbSortBy";
            this.cmbSortBy.Size = new System.Drawing.Size(160, 31);
            this.cmbSortBy.TabIndex = 6;
            this.cmbSortBy.SelectedIndexChanged += new System.EventHandler(this.cmbSortBy_SelectedIndexChanged);
            // 
            // dgvLastViewed
            // 
            this.dgvLastViewed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLastViewed.BackgroundColor = System.Drawing.Color.White;
            this.dgvLastViewed.ColumnHeadersHeight = 29;
            this.dgvLastViewed.Location = new System.Drawing.Point(15, 40);
            this.dgvLastViewed.Name = "dgvLastViewed";
            this.dgvLastViewed.RowHeadersWidth = 51;
            this.dgvLastViewed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLastViewed.Size = new System.Drawing.Size(1080, 80);
            this.dgvLastViewed.TabIndex = 1;
            // 
            // dgvRecommendations
            // 
            this.dgvRecommendations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecommendations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecommendations.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecommendations.ColumnHeadersHeight = 29;
            this.dgvRecommendations.Location = new System.Drawing.Point(15, 45);
            this.dgvRecommendations.Name = "dgvRecommendations";
            this.dgvRecommendations.RowHeadersWidth = 51;
            this.dgvRecommendations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRecommendations.Size = new System.Drawing.Size(1080, 100);
            this.dgvRecommendations.TabIndex = 2;
            // 
            // cmbCategoryFilter
            // 
            this.cmbCategoryFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategoryFilter.Location = new System.Drawing.Point(693, 12);
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            this.cmbCategoryFilter.Size = new System.Drawing.Size(160, 31);
            this.cmbCategoryFilter.TabIndex = 3;
            // 
            // lblResultsCount
            // 
            this.lblResultsCount.Location = new System.Drawing.Point(950, 150);
            this.lblResultsCount.Name = "lblResultsCount";
            this.lblResultsCount.Size = new System.Drawing.Size(200, 25);
            this.lblResultsCount.TabIndex = 2;
            this.lblResultsCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(15, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(65, 23);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(15, 55);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(68, 23);
            this.lblSort.TabIndex = 5;
            this.lblSort.Text = "Sort By:";
            // 
            // lblLastViewed
            // 
            this.lblLastViewed.AutoSize = true;
            this.lblLastViewed.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblLastViewed.Location = new System.Drawing.Point(15, 10);
            this.lblLastViewed.Name = "lblLastViewed";
            this.lblLastViewed.Size = new System.Drawing.Size(152, 25);
            this.lblLastViewed.TabIndex = 0;
            this.lblLastViewed.Text = "Recently Viewed";
            // 
            // lblAllEvents
            // 
            this.lblAllEvents.AutoSize = true;
            this.lblAllEvents.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblAllEvents.Location = new System.Drawing.Point(15, 10);
            this.lblAllEvents.Name = "lblAllEvents";
            this.lblAllEvents.Size = new System.Drawing.Size(96, 25);
            this.lblAllEvents.TabIndex = 0;
            this.lblAllEvents.Text = "All Events";
            // 
            // lblRecommendations
            // 
            this.lblRecommendations.AutoSize = true;
            this.lblRecommendations.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblRecommendations.Location = new System.Drawing.Point(15, 10);
            this.lblRecommendations.Name = "lblRecommendations";
            this.lblRecommendations.Size = new System.Drawing.Size(171, 25);
            this.lblRecommendations.TabIndex = 0;
            this.lblRecommendations.Text = "Recommendations";
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1421, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Events and Announcements";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 18;
            // 
            // btnRefreshRecs
            // 
            this.btnRefreshRecs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(90)))));
            this.btnRefreshRecs.FlatAppearance.BorderSize = 0;
            this.btnRefreshRecs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshRecs.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnRefreshRecs.ForeColor = System.Drawing.Color.White;
            this.btnRefreshRecs.Location = new System.Drawing.Point(850, 150);
            this.btnRefreshRecs.Name = "btnRefreshRecs";
            this.btnRefreshRecs.Size = new System.Drawing.Size(245, 30);
            this.btnRefreshRecs.TabIndex = 1;
            this.btnRefreshRecs.Text = "Refresh Recommendations";
            this.btnRefreshRecs.UseVisualStyleBackColor = false;
            this.btnRefreshRecs.Click += new System.EventHandler(this.btnRefreshRecs_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(270, 50);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 34);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear Filters";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCategoryFilter
            // 
            this.lblCategoryFilter.AutoSize = true;
            this.lblCategoryFilter.Location = new System.Drawing.Point(568, 15);
            this.lblCategoryFilter.Name = "lblCategoryFilter";
            this.lblCategoryFilter.Size = new System.Drawing.Size(83, 23);
            this.lblCategoryFilter.TabIndex = 2;
            this.lblCategoryFilter.Text = "Category:";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(90)))));
            this.panelHeader.Controls.Add(this.ExitBtn);
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Controls.Add(this.backBtn);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1421, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(1130, 10);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(50, 50);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(10, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 1;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.White;
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.lblSearch);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.lblCategoryFilter);
            this.panelSearch.Controls.Add(this.cmbCategoryFilter);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.lblSort);
            this.panelSearch.Controls.Add(this.cmbSortBy);
            this.panelSearch.Controls.Add(this.btnClear);
            this.panelSearch.Location = new System.Drawing.Point(40, 90);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1096, 90);
            this.panelSearch.TabIndex = 1;
            // 
            // panelEvents
            // 
            this.panelEvents.BackColor = System.Drawing.Color.White;
            this.panelEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEvents.Controls.Add(this.lblAllEvents);
            this.panelEvents.Controls.Add(this.dgvEvents);
            this.panelEvents.Controls.Add(this.lblResultsCount);
            this.panelEvents.Location = new System.Drawing.Point(40, 370);
            this.panelEvents.Name = "panelEvents";
            this.panelEvents.Size = new System.Drawing.Size(1120, 400);
            this.panelEvents.TabIndex = 3;
            // 
            // panelViewed
            // 
            this.panelViewed.BackColor = System.Drawing.Color.White;
            this.panelViewed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelViewed.Controls.Add(this.lblLastViewed);
            this.panelViewed.Controls.Add(this.dgvLastViewed);
            this.panelViewed.Location = new System.Drawing.Point(40, 200);
            this.panelViewed.Name = "panelViewed";
            this.panelViewed.Size = new System.Drawing.Size(1096, 150);
            this.panelViewed.TabIndex = 2;
            // 
            // panelRecs
            // 
            this.panelRecs.BackColor = System.Drawing.Color.White;
            this.panelRecs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRecs.Controls.Add(this.lblRecommendations);
            this.panelRecs.Controls.Add(this.btnRefreshRecs);
            this.panelRecs.Controls.Add(this.dgvRecommendations);
            this.panelRecs.Location = new System.Drawing.Point(40, 790);
            this.panelRecs.Name = "panelRecs";
            this.panelRecs.Padding = new System.Windows.Forms.Padding(10);
            this.panelRecs.Size = new System.Drawing.Size(1120, 230);
            this.panelRecs.TabIndex = 4;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Black;
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(1196, 290);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(146, 128);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 5;
            this.Logo.TabStop = false;
            // 
            // statsPanel
            // 
            this.statsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.statsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statsPanel.Controls.Add(this.lblAnalyticsTitle);
            this.statsPanel.Controls.Add(this.lblMostPopularCategory);
            this.statsPanel.Controls.Add(this.lblTotalSearches);
            this.statsPanel.Location = new System.Drawing.Point(1171, 90);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(218, 150);
            this.statsPanel.TabIndex = 6;
            // 
            // lblAnalyticsTitle
            // 
            this.lblAnalyticsTitle.AutoSize = true;
            this.lblAnalyticsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalyticsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.lblAnalyticsTitle.Location = new System.Drawing.Point(10, 12);
            this.lblAnalyticsTitle.Name = "lblAnalyticsTitle";
            this.lblAnalyticsTitle.Size = new System.Drawing.Size(168, 28);
            this.lblAnalyticsTitle.TabIndex = 0;
            this.lblAnalyticsTitle.Text = "Search Analytics";
            // 
            // lblMostPopularCategory
            // 
            this.lblMostPopularCategory.AutoSize = true;
            this.lblMostPopularCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostPopularCategory.Location = new System.Drawing.Point(10, 52);
            this.lblMostPopularCategory.Name = "lblMostPopularCategory";
            this.lblMostPopularCategory.Size = new System.Drawing.Size(203, 20);
            this.lblMostPopularCategory.TabIndex = 1;
            this.lblMostPopularCategory.Text = "Most Popular Category: None";
            // 
            // lblTotalSearches
            // 
            this.lblTotalSearches.AutoSize = true;
            this.lblTotalSearches.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSearches.Location = new System.Drawing.Point(10, 85);
            this.lblTotalSearches.Name = "lblTotalSearches";
            this.lblTotalSearches.Size = new System.Drawing.Size(119, 20);
            this.lblTotalSearches.TabIndex = 2;
            this.lblTotalSearches.Text = "Total Searches: 0";
            // 
            // EventsAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1442, 780);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelViewed);
            this.Controls.Add(this.panelEvents);
            this.Controls.Add(this.panelRecs);
            this.Controls.Add(this.statsPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "EventsAnnouncements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events and Announcements";
            this.Load += new System.EventHandler(this.EventsAnnouncements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLastViewed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecommendations)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelEvents.ResumeLayout(false);
            this.panelEvents.PerformLayout();
            this.panelViewed.ResumeLayout(false);
            this.panelViewed.PerformLayout();
            this.panelRecs.ResumeLayout(false);
            this.panelRecs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSortBy;
        private System.Windows.Forms.DataGridView dgvLastViewed;
        private System.Windows.Forms.DataGridView dgvRecommendations;
        private System.Windows.Forms.ComboBox cmbCategoryFilter;
        private System.Windows.Forms.Label lblResultsCount;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Label lblLastViewed;
        private System.Windows.Forms.Label lblAllEvents;
        private System.Windows.Forms.Label lblRecommendations;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button btnRefreshRecs;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCategoryFilter;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelEvents;
        private System.Windows.Forms.Panel panelViewed;
        private System.Windows.Forms.Panel panelRecs;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button ExitBtn;
        private PictureBox Logo;
        private Panel statsPanel;
        private Label lblAnalyticsTitle;
        private Label lblMostPopularCategory;
        private Label lblTotalSearches;
    }
}

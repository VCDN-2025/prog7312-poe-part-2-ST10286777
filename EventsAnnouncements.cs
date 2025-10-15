using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Municipal_Services
{
    public partial class EventsAnnouncements : Form
    {
        private EventManager eventManager;

        public EventsAnnouncements()
        {
            InitializeComponent();
            eventManager = new EventManager();
            SetupImprovedLayout();
            dgvEvents.CellClick += dgvEvents_CellClick;
            dgvLastViewed.CellClick += dgvLastViewed_CellClick;
            dgvRecommendations.CellClick += dgvRecommendations_CellClick;
        }

      

        private void SetupImprovedLayout()
        {
            // Configure main events grid
            dgvEvents.AutoGenerateColumns = false;
            dgvEvents.Columns.Clear();
            dgvEvents.Columns.AddRange(
                new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Event Name", Width = 150 },
                new DataGridViewTextBoxColumn { DataPropertyName = "EventDate", HeaderText = "Date", Width = 80 },
                new DataGridViewTextBoxColumn { DataPropertyName = "Category", HeaderText = "Category", Width = 100 },
                new DataGridViewTextBoxColumn { DataPropertyName = "Location", HeaderText = "Location", Width = 120 },
                new DataGridViewTextBoxColumn { DataPropertyName = "Description", HeaderText = "Description", Width = 200 }
            );

            // Configure last viewed grid
            dgvLastViewed.AutoGenerateColumns = false;
            dgvLastViewed.Columns.Clear();
            dgvLastViewed.Columns.AddRange(
                new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Recently Viewed", Width = 120 },
                new DataGridViewTextBoxColumn { DataPropertyName = "EventDate", HeaderText = "Date", Width = 70 },
                new DataGridViewTextBoxColumn { DataPropertyName = "Category", HeaderText = "Category", Width = 80 }
            );

            // Configure recommendations grid
            dgvRecommendations.AutoGenerateColumns = false;
            dgvRecommendations.Columns.Clear();
            dgvRecommendations.Columns.AddRange(
                new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Recommended For You", Width = 140 },
                new DataGridViewTextBoxColumn { DataPropertyName = "EventDate", HeaderText = "Date", Width = 70 },
                new DataGridViewTextBoxColumn { DataPropertyName = "Category", HeaderText = "Category", Width = 80 }
            );

            // Style improvements
            dgvEvents.RowHeadersVisible = false;
            dgvLastViewed.RowHeadersVisible = false;
            dgvRecommendations.RowHeadersVisible = false;

            dgvEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLastViewed.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecommendations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Alternating row colors
            dgvEvents.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 246, 248);
            dgvLastViewed.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 250, 240);
            dgvRecommendations.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);

            // Grid appearance
            dgvEvents.BackgroundColor = Color.White;
            dgvEvents.BorderStyle = BorderStyle.FixedSingle;
            dgvEvents.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 216, 230);
            dgvEvents.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void UpdateSearchAnalyticsDisplay()
        {
            int totalSearches = eventManager.GetTotalSearches();
            string mostPopularCategory = eventManager.GetMostPopularCategory();
            int popularCategoryCount = eventManager.GetMostPopularCategoryCount();

            lblTotalSearches.Text = $"Total Searches: {totalSearches}";

            if (mostPopularCategory != "None" && popularCategoryCount > 0)
            {
                lblMostPopularCategory.Text = $"Most Popular: {mostPopularCategory} ({popularCategoryCount} searches)";
                if (popularCategoryCount >= 5)
                    lblMostPopularCategory.ForeColor = Color.FromArgb(220, 0, 0); 
                else if (popularCategoryCount >= 3)
                    lblMostPopularCategory.ForeColor = Color.FromArgb(255, 140, 0); 
                else
                    lblMostPopularCategory.ForeColor = Color.FromArgb(0, 100, 0); 
            }
            else
            {
                lblMostPopularCategory.Text = "Most Popular Category: None";
                lblMostPopularCategory.ForeColor = Color.Gray;
            }
            if (totalSearches >= 10)
                lblTotalSearches.ForeColor = Color.FromArgb(0, 100, 0); 
            else if (totalSearches >= 5)
                lblTotalSearches.ForeColor = Color.FromArgb(255, 140, 0);
            else
                lblTotalSearches.ForeColor = Color.Gray;
        }

        private void EventsAnnouncements_Load(object sender, EventArgs e)
        {
            DisplayAllEvents();
            PopulateFilterControls();
            UpdateLastViewedDisplay();
            UpdateRecommendationsDisplay();
            UpdateSearchAnalyticsDisplay();
        }

        private void PopulateFilterControls()
        {
            // Populate category filter
            cmbCategoryFilter.Items.Clear();
            cmbCategoryFilter.Items.Add("All Categories");
            foreach (var category in eventManager.GetCategories())
            {
                cmbCategoryFilter.Items.Add(category);
            }
            cmbCategoryFilter.SelectedIndex = 0;

            // Populate sort options
            cmbSortBy.Items.Clear();
            cmbSortBy.Items.AddRange(new[] { "Date", "Name", "Category" });
            cmbSortBy.SelectedIndex = 0;
        }

        private void DisplayEvents(IEnumerable<Event> events)
        {
            dgvEvents.DataSource = null;
            dgvEvents.DataSource = new BindingList<Event>(events.ToList());
        }

        private void UpdateLastViewedDisplay()
        {
            var lastViewed = eventManager.GetLastViewedEvents();

            if (!lastViewed.Any())
            {
                // show placeholder row
                var emptyList = new List<Event> { new Event { Name = "No recently viewed events" } };
                dgvLastViewed.DataSource = null;
                dgvLastViewed.DataSource = new BindingList<Event>(emptyList);
            }
            else
            {
                // show last viewed events
                dgvLastViewed.DataSource = null;
                dgvLastViewed.DataSource = new BindingList<Event>(lastViewed);
            }
        }

        private void UpdateRecommendationsDisplay()
        {
            var recommendations = eventManager.GetRecommendations();
            dgvRecommendations.DataSource = null;
            dgvRecommendations.DataSource = new BindingList<Event>(recommendations.ToList());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            string categoryFilter = cmbCategoryFilter.SelectedItem?.ToString();

            if (categoryFilter == "All Categories")
                categoryFilter = null;

            var results = eventManager.SearchEvents(searchTerm, categoryFilter);
            DisplayEvents(results);

            // Refresh recommendations based on search
            UpdateRecommendationsDisplay();
            UpdateSearchAnalyticsDisplay();
        }

        // Sort events when sort option changes
        private void cmbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvEvents.DataSource is BindingList<Event> currentEvents)
            {
                var sortedEvents = eventManager.SortEvents(cmbSortBy.SelectedItem.ToString());
                DisplayEvents(sortedEvents);
            }
        }

        // Filter events when category changes
        private void cmbCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategoryFilter.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedCategory))
            {
                var filteredEvents = eventManager.FilterEventsByCategory(selectedCategory);
                DisplayEvents(filteredEvents);

                UpdateRecommendationsDisplay();
                UpdateSearchAnalyticsDisplay();
            }
        }

        private void dgvEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvEvents.Rows[e.RowIndex].DataBoundItem is Event selectedEvent)
            {
                // Add to recently viewed
                eventManager.AddToRecentlyViewed(selectedEvent);
                UpdateLastViewedDisplay();

                // Show event details in a user-friendly way
                ShowEventDetails(selectedEvent);
            }
        }

        private void dgvLastViewed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLastViewed.Rows[e.RowIndex].DataBoundItem is Event selectedEvent && !string.IsNullOrEmpty(selectedEvent.Name))
            {
                ShowEventDetails(selectedEvent);
            }
        }

        private void dgvRecommendations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvRecommendations.Rows[e.RowIndex].DataBoundItem is Event selectedEvent)
            {
                // Add to recently viewed when clicking on recommendation
                eventManager.AddToRecentlyViewed(selectedEvent);
                UpdateLastViewedDisplay();
                ShowEventDetails(selectedEvent);
            }
        }

        private void ShowEventDetails(Event eventItem)
        {
            if (eventItem == null) return;

            string details = $@"Event: {eventItem.Name}
            Date: {eventItem.EventDate:dddd, MMMM dd, yyyy}
            Category: {eventItem.Category}
            Location: {eventItem.Location}

            Description:
            {eventItem.Description}";

            MessageBox.Show(details, "Event Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void DisplayAllEvents()
        {
            var all = eventManager.GetAllEvents().ToList();
            DisplayEvents(all);
        }

        private void btnRefreshRecs_Click(object sender, EventArgs e)
        {
            UpdateRecommendationsDisplay();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbCategoryFilter.SelectedIndex = 0;
            cmbSortBy.SelectedIndex = 0;
            DisplayAllEvents();
            UpdateRecommendationsDisplay();
            UpdateSearchAnalyticsDisplay();

        }

        private void ExitBtn_Click_1(object sender, EventArgs e)
        {

            //Exits the application
            Application.Exit();

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            //Navigatess users to the Main Menu
            MainMenu f2 = new MainMenu();
            f2.Show();
            this.Hide();

        }

    
    }
}

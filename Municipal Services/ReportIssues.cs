using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Municipal_Services
{
    public partial class ReportIssues : Form
    {
        public ReportIssues()
        {
            InitializeComponent();
        }

        private void ReportIssues_Load(object sender, EventArgs e)
        {

        // Populate provinces
        cmbProvince.Items.AddRange(new string[] {
           "Eastern Cape",
           "Free State",
           "Gauteng",
           "KwaZulu-Natal",
           "Limpopo",
           "Mpumalanga",
           "North West",
           "Northern Cape",
           "Western Cape"
            });

            // Populate categories
            cmbCategory.Items.AddRange(new string[] {
             "Roads and Transportation",
             "Water and Sanitation",
             "Electricity",
             "Waste Management",
             "Public Safety",
              "Parks and Recreation",
              "Other"
            });

           
        }

        
        

        private void backBtn_Click(object sender, EventArgs e)
        {
            //Navigatess users to the Main Menu
            MainMenu f2 = new MainMenu();
            f2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Exits the application
            Application.Exit();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            // Validates the Form
            if (!ValidateForm())
            {
                return;
            }

            try
            {
                // Create new issue object
                Issue newIssue = new Issue
                {
                    StreetAddress = txtStreetAddress.Text.Trim(),
                    Suburb = txtSuburb.Text.Trim(),
                    City = txtCity.Text.Trim(),
                    Province = cmbProvince.SelectedItem?.ToString(),
                    PostalCode = txtPostalCode.Text.Trim(),
                    Category = cmbCategory.SelectedItem?.ToString(),
                    Description = rtbDescription.Text.Trim(),
                    AttachmentPath = ofdAttachments.FileName ?? ""
                };

                // Store the issue using custom data structure
                IssueManager.AddIssue(newIssue);

                // Show success message with community engagement info
                string communityStats = IssueManager.GetCommunityStats();

                //Displays all entered information as well as the current amount of issues reported in the community 
                string successMessage = $"Issue #{newIssue.IssueId} reported successfully!\n\n" +
                                 "SUBMITTED DETAILS:\n" +
                                 "═══════════════════════════════\n" +
                                 $"Address: {newIssue.StreetAddress}\n" +
                                 $"Suburb: {newIssue.Suburb}\n" +
                                 $"City: {newIssue.City}\n" +
                                 $"Province: {newIssue.Province}\n" +
                                 $"Postal Code: {newIssue.PostalCode}\n" +
                                 $"Category: {newIssue.Category}\n" +
                                 $"Description: {(newIssue.Description.Length > 100 ? newIssue.Description.Substring(0, 100) + "..." : newIssue.Description)}\n" +
                                 $"{newIssue.AttachmentPath}\n" +
                                 $"Date Reported: {newIssue.DateReported:yyyy-MM-dd HH:mm}\n\n" +
                                 $"{communityStats}\n\n" +
                                 "Thank you for helping improve our community!";

                MessageBox.Show(successMessage, "Report Submitted",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Clears form
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error submitting report: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {

            // Check Street Address
            if (string.IsNullOrWhiteSpace(txtStreetAddress.Text) ||
                txtStreetAddress.Text.Trim() == "Enter Street number and Name")
            {
                MessageBox.Show("Please enter a valid street address.", "Required Field",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStreetAddress.Focus();
                return false;
            }

            // Check Suburb
            if (string.IsNullOrWhiteSpace(txtSuburb.Text) ||
                txtSuburb.Text.Trim() == "Enter Suburb or Area")
            {
                MessageBox.Show("Please enter a suburb or area.", "Required Field",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSuburb.Focus();
                return false;
            }

            // Check City
            if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show("Please enter a city.", "Required Field",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCity.Focus();
                return false;
            }


            // Check Province selection
            if (cmbProvince.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a province.", "Required Field",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProvince.Focus();
                return false;
            }

            // Check Postal Code
            if (string.IsNullOrWhiteSpace(txtPostalCode.Text) ||
                txtPostalCode.Text.Trim() == "0000")
            {
                MessageBox.Show("Please enter a valid postal code.", "Required Field",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPostalCode.Focus();
                return false;
            }


            // Check Category selection
            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category for your issue.", "Required Field",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategory.Focus();
                return false;
            }

            // Check Description
            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show("Please provide a description of the issue.", "Required Field",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rtbDescription.Focus();
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtStreetAddress.Text = string.Empty;
            txtSuburb.Text = string.Empty;
            txtCity.Text = string.Empty;
            cmbProvince.SelectedIndex = -1;
            txtPostalCode.Text = string.Empty;
            cmbCategory.SelectedIndex = -1;
            rtbDescription.Text = string.Empty;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
           
                // Show the dialog and check if user selected a file
                if (ofdAttachments.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = ofdAttachments.FileName;

                    // Validate file size (limit to 10MB)
                    FileInfo fileInfo = new FileInfo(selectedFile);
                    long maxSizeInBytes = 10 * 1024 * 1024;

                    if (fileInfo.Length > maxSizeInBytes)
                    {
                        MessageBox.Show("File size exceeds the 10MB limit. Please select a smaller file.",
                                       "File Too Large", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Update UI to show selected file
                    string fileName = Path.GetFileName(selectedFile);

                    // Show confirmation message
                    MessageBox.Show($"File '{fileName}' has been selected successfully.",
                                   "File Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting file: {ex.Message}",
                               "File Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

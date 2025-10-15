using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Municipal_Services
{
    public partial class MainMenu : Form
    {
        

        private void EventsBtn_Click(object sender, EventArgs e)
        {
            //Navigatess users to the Events and Announcements form
            EventsAnnouncements events = new EventsAnnouncements();
            events.Show();
            this.Hide();
        }

        private void StatusBtn_Click(object sender, EventArgs e)
        {
            //Displays a message box indicating that the feature is coming soon
            MessageBox.Show(
         "The status of your reported issues feature will be implemented in a future update.\n\nStay tuned for exciting new features!",
         "Coming Soon",
         MessageBoxButtons.OK,
         MessageBoxIcon.Information
     );
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            //Exits the application
            Application.Exit();

        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            //Navigatess users to the Report Issues form
            ReportIssues f2 = new ReportIssues();
            f2.Show();
            this.Hide();
        }


      
        public MainMenu()
        {
            InitializeComponent();
        }
    }
}

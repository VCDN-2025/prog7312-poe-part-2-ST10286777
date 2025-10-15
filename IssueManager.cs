using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_Services
{
    public static class IssueManager
    {
        private static IssueCollection Issues = new IssueCollection();

        public static IssueCollection Issue
        {
            get { return Issues; }
        }

        public static void AddIssue(Issue issue)
        {
            Issues.Add(issue);
        }

        public static Issue GetIssueById(int id)
        {
            return Issues.FindById(id);
        }

        public static Issue[] GetAllIssues()
        {
            return Issues.GetAllIssues();
        }

        public static Issue[] SearchByCategory(string category)
        {
            return Issues.FindByCategory(category);
        }

        public static Issue[] SearchByLocation(string location)
        {
            return Issues.FindByLocation(location);
        }

        public static int GetTotalIssueCount()
        {
            return Issues.Count;
        }

        // Engagement strategy - show community involvement
        public static string GetCommunityStats()
        {
            int totalIssues = Issues.Count;
            // For now, we'll simulate resolved issues
            int resolvedIssues = (int)(totalIssues * 0.7); // 70% resolved rate

            return $"Community Impact: {totalIssues} issues reported, {resolvedIssues} resolved";
        }
    }
}

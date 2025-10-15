using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_Services
{
    public class Issue
    {
        public int IssueId { get; set; }
        public string StreetAddress { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string AttachmentPath { get; set; }
        public DateTime DateReported { get; set; }
        public string Status { get; set; }

        public Issue()
        {
            DateReported = DateTime.Now;
            Status = "Submitted";
        }

        public string GetFullAddress()
        {
            return $"{StreetAddress}, {Suburb}, {City}, {Province} {PostalCode}";
        }

        public override string ToString()
        {
            return $"Issue #{IssueId}: {Category} - {StreetAddress}, {Suburb}";
        }
    }
}


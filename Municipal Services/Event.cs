using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_Services
{
    public class Event
    {
        //A global unique identifier for the event
        public Guid EventId { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public DateTime EventDate{ get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Location{ get; set; }

        public string ToString()
        {
            return $"{Name} ({Category}) - {EventDate:yyyy-MM-dd}";
        }
    }
 }

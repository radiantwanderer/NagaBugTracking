using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NagaBugTracking.Models
{
    public class Bug
    {
        public enum BugType 
        { 
            Defect = 0,
            Enhancement = 1,
            Task = 2
        }

        public enum Severity
        {
            Blocker = 0,
            Critical = 1,
            Normal = 2,
            Minor = 3
        }

        public enum Status
        {
            Unconfirmed = 0,
            New = 1,
            Assigned = 2,
            Resolved = 3,
            Verified = 4,
            Reopen = 5,
            Closed = 6
        }

        public enum Platform
        {
            Windows = 0,
            Mac = 1,
            Linux = 2
        }

        public bool Open { get; set; }

        public int Id { get; set; }
        public int Priority { get; set; }
        public float Version { get; set; }

        public string Summary { get; set; }
        public string Description { get; set; }
        public string Product { get; set; }
        public string Component { get; set; }
        public string Reporter { get; set; }
        public string Assignee { get; set; }

        public BugType BugCategory { get; set; }
        public Severity SeverityLevel { get; set; }
        public Status State { get; set; }
        public List<Platform> Platforms { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateFound { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastEdited { get; set; }

        public Bug()
        {
            
        }
    }
}

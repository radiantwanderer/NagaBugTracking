using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NagaBugTracking.Models
{
    public class BugModel
    {
        public int Id { get; set; }

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
            Unspecified = 0,
            Windows = 1,
            Mac = 2,
            Linux = 3,
            All = 4
        }

        private bool open;

        private float version;
        private int priority;

        private string summary;
        private string description;
        private string product;
        private string component;
        private string reporter;
        private string assignee;

        private BugType bugType;
        private Severity severity;
        private Status status;
        private Platform platform;

        [DataType(DataType.Date)]
        private DateTime dateFound;

        [DataType(DataType.Date)]
        private DateTime lastEdited;
    }
}

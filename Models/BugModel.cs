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

        private string summary;
        private string description;

        [DataType(DataType.Date)]
        private DateTime dateFound;

        [DataType(DataType.Date)]
        private DateTime lastEdited;
    }
}

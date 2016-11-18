using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbsenceTracker.WebApi.ViewModels
{
    public class CompensationView
    {
        public string Id { get; set; }
        public string AbsenceId { get; set; }
        public System.DateTime AbsenceDate { get; set; }
        public int EstimatedTime { get; set; }
        public int TotalSpentTime { get; set; }
        public virtual AbsenceView Absence { get; set; }
        public virtual ICollection<CompensationEntryView> CompensationEntry { get; set; }
    }
}
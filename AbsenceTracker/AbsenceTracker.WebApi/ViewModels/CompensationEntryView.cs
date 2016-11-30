using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbsenceTracker.WebApi.ViewModels
{
    public class CompensationEntryView
    {
        public Guid Id { get; set; }
        public Guid CompensationId { get; set; }
        public System.DateTime Date { get; set; }
        public int SpentTime { get; set; }

        CompensationView Compensation { get; set; }
    }
}
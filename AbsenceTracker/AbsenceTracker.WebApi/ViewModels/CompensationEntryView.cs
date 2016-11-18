﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbsenceTracker.WebApi.ViewModels
{
    public class CompensationEntryView
    {
        public string Id { get; set; }
        public string CompensationId { get; set; }
        public System.DateTime Date { get; set; }
        public int SpentTime { get; set; }
        public virtual CompensationView Compensation { get; set; }
    }
}
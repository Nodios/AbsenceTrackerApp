﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbsenceTracker.WebApi.ViewModels
{
    public class VacationView
    {
        public string Id { get; set; }
        public string AbsenceId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int Time { get; set; }
        public int TimeLeft { get; set; }

        public virtual AbsenceView Absence { get; set; }
    }
}
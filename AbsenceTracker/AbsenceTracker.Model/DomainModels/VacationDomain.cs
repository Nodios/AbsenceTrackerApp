﻿using AbsenceTracker.Model.Common.IDomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Model.DomainModels
{
    public class VacationDomain : IVacationDomain
    {
        public string Id { get; set; }
        public string AbsenceId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int Time { get; set; }
        public int TimeLeft { get; set; }

        public virtual IAbsenceDomain Absence { get; set; }
    }
}
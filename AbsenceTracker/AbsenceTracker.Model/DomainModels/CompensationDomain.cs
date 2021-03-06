﻿using AbsenceTracker.Model.Common.IDomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Model.DomainModels
{
    public class CompensationDomain : ICompensationDomain
    {
        public Guid Id { get; set; }
        public System.DateTime AbsenceDate { get; set; }
        public int EstimatedTime { get; set; }
        public int TotalSpentTime { get; set; }
        public Guid AbsenceId { get; set; }

        public virtual ICollection<ICompensationEntryDomain> CompensationEntries { get; set; }
    }
}

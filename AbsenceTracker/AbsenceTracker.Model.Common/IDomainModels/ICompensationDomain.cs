using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Model.Common.IDomainModels
{
    public interface ICompensationDomain
    {
        string Id { get; set; }
        System.DateTime AbsenceDate { get; set; }
        int EstimatedTime { get; set; }
        int TotalSpentTime { get; set; }
        IAbsenceDomain Absence { get; set; }
        ICollection<ICompensationEntryDomain> CompensationEntries { get; set; }
    }
}

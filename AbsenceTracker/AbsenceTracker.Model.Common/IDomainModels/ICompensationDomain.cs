using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Model.Common.IDomainModels
{
    public interface ICompensationDomain
    {
        Guid Id { get; set; }
        System.DateTime AbsenceDate { get; set; }
        int EstimatedTime { get; set; }
        int TotalSpentTime { get; set; }
        Guid AbsenceId { get; set; }

        ICollection<ICompensationEntryDomain> CompensationEntries { get; set; }
    }
}

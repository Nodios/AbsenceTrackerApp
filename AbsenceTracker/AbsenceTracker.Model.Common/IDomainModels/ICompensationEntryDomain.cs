using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Model.Common.IDomainModels
{
    public interface ICompensationEntryDomain
    {
        Guid Id { get; set; }
        Guid CompensationId { get; set; }
        System.DateTime Date { get; set; }
        int SpentTime { get; set; }

        ICompensationDomain Compensation { get; set; }
    }
}

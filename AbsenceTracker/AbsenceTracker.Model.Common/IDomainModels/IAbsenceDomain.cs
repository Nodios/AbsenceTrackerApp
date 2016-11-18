using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Model.Common.IDomainModels
{
    public interface IAbsenceDomain
    {
        string Id { get; set; }
        string UserId { get; set; }
        string AssigneeId { get; set; }
        string Type { get; set; }
        string Status { get; set; }

        IAspNetUsersDomain AspNetUser { get; set; }
        IAspNetUsersDomain AspNetUserAssignee { get; set; }
        ICollection<ICompensationDomain> Compensation { get; set; }
        ICollection<ISicknessDomain> Sickness { get; set; }
        ICollection<IVacationDomain> Vacation { get; set; }
    }
}

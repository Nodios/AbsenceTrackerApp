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

        IAspNetUserDomain AspNetUser { get; set; }
        IAspNetUserDomain AspNetUserAssignee { get; set; }
        ICompensationDomain Compensation { get; set; }
        ISicknessDomain Sickness { get; set; }
        IVacationDomain Vacation { get; set; }
    }
}

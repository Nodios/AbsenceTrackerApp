using AbsenceTracker.Model.Common.IDomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Model.DomainModels
{
    public class AbsenceDomain : IAbsenceDomain
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string AssigneeId { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
    
        public virtual IAspNetUserDomain AspNetUser { get; set; }
        public virtual IAspNetUserDomain AspNetUserAssignee { get; set; }
        public virtual ICompensationDomain Compensation { get; set; }
        public virtual ISicknessDomain Sickness { get; set; }
        public virtual IVacationDomain Vacation { get; set; }
    }
}

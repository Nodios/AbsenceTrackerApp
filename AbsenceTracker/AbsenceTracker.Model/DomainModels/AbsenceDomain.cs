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

        public virtual IAspNetUsersDomain AspNetUser { get; set; }
        public virtual IAspNetUsersDomain AspNetUserAssignee { get; set; }
        public virtual ICollection<ICompensationDomain> Compensation { get; set; }
        public virtual ICollection<ISicknessDomain> Sickness { get; set; }
        public virtual ICollection<IVacationDomain> Vacation { get; set; }
    }
}

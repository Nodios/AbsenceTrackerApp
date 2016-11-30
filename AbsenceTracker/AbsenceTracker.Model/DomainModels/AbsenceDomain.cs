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
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public string AssignedBy { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }

        public virtual ICollection<ICompensationDomain> Compensations { get; set; }
        public virtual ICollection<ISicknessDomain> Sicknesses { get; set; }
        public virtual ICollection<IVacationDomain> Vacations { get; set; }
    }
}

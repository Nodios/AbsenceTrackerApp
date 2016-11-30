using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Model.Common.IDomainModels
{
    public interface IAbsenceDomain
    {
        Guid Id { get; set; }
        string UserId { get; set; }
        string AssignedBy { get; set; }
        string Type { get; set; }
        string Status { get; set; }

        ICollection<ICompensationDomain> Compensations { get; set; }
        ICollection<ISicknessDomain> Sicknesses { get; set; }
        ICollection<IVacationDomain> Vacations { get; set; }
    }
}

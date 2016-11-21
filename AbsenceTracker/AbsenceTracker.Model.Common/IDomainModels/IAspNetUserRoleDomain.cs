using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Model.Common.IDomainModels
{
    public interface IAspNetUserRoleDomain
    {
        string Id { get; set; }
        string Name { get; set; }
        ICollection<IAspNetUserDomain> AspNetUsers { get; set; }
    }
}

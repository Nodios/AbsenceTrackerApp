using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Model.Common.IDomainModels
{
    public interface IAspNetRolesDomain
    {
        string Id { get; set; }
        string Name { get; set; }
        ICollection<IAspNetUsersDomain> AspNetUsers { get; set; }
    }
}

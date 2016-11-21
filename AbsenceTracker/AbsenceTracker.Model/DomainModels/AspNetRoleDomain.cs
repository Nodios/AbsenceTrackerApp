using AbsenceTracker.Model.Common.IDomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Model.DomainModels
{
    public class AspNetRoleDomain : IAspNetRoleDomain
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<IAspNetUserDomain> AspNetUsers { get; set; }
    }
}

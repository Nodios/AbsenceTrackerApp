using AbsenceTracker.Model.Common.IDomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Model.DomainModels
{
    public class AspNetUsersDomain : IAspNetUsersDomain
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<IAbsenceDomain> Absence { get; set; }
        public virtual ICollection<IAbsenceDomain> Absence1 { get; set; }
        public virtual ICollection<IAspNetUserClaimsDomain> AspNetUserClaims { get; set; }
        public virtual ICollection<IAspNetUserLoginsDomain> AspNetUserLogins { get; set; }
        public virtual ICollection<IAspNetRolesDomain> AspNetRoles { get; set; }
    }
}

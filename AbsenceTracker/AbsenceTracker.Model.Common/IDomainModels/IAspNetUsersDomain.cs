using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Model.Common.IDomainModels
{
    public interface IAspNetUsersDomain
    {
        string Id { get; set; }
        string Email { get; set; }
        bool EmailConfirmed { get; set; }
        string PasswordHash { get; set; }
        string SecurityStamp { get; set; }
        string PhoneNumber { get; set; }
        bool PhoneNumberConfirmed { get; set; }
        bool TwoFactorEnabled { get; set; }
        Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
        bool LockoutEnabled { get; set; }
        int AccessFailedCount { get; set; }
        string UserName { get; set; }

        ICollection<IAbsenceDomain> Absence { get; set; }
        ICollection<IAbsenceDomain> Absence1 { get; set; }
        ICollection<IAspNetUserClaimsDomain> AspNetUserClaims { get; set; }
        ICollection<IAspNetUserLoginsDomain> AspNetUserLogins { get; set; }
        ICollection<IAspNetRolesDomain> AspNetRoles { get; set; }
    }
}

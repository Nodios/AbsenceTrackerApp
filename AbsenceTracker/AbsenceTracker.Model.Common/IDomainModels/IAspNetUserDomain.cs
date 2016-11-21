using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Model.Common.IDomainModels
{
    public interface IAspNetUserDomain
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

        ICollection<IAbsenceDomain> Absences { get; set; }
        ICollection<IAbsenceDomain> AbsencesAssignee { get; set; }
        ICollection<IAspNetUserClaimDomain> AspNetUserClaims { get; set; }
        ICollection<IAspNetUserLoginDomain> AspNetUserLogins { get; set; }
        ICollection<IAspNetUserRoleDomain> AspNetRoles { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Model.Common.IDomainModels
{
    public interface IAspNetUserClaimsDomain
    {
        int Id { get; set; }
        string UserId { get; set; }
        string ClaimType { get; set; }
        string ClaimValue { get; set; }
        IAspNetUsersDomain AspNetUsers { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Model.Common.IDomainModels
{
    public interface IAspNetUserLoginsDomain
    {
        string LoginProvider { get; set; }
        string ProviderKey { get; set; }
        string UserId { get; set; }

        IAspNetUsersDomain AspNetUsers { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Model.Common.IDomainModels
{
    public interface IVacationDomain
    {
        string Id { get; set; }
        System.DateTime StartDate { get; set; }
        System.DateTime EndDate { get; set; }
        int Time { get; set; }
        int TimeLeft { get; set; }
        string AbsenceId { get; set; }
    }
}

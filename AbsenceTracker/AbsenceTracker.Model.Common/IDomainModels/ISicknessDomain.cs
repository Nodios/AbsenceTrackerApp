using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Model.Common.IDomainModels
{
    public interface ISicknessDomain
    {
        string Id { get; set; }
        string AbsenceId { get; set; }
        System.DateTime StartDate { get; set; }
        System.DateTime EndDate { get; set; }
        int Time { get; set; }

        IAbsenceDomain Absence { get; set; }
    }
}

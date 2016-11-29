using AbsenceTracker.Model.Common.IDomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Model.DomainModels
{
    public class CompensationEntryDomain : ICompensationEntryDomain
    {
        public string Id { get; set; }
        public string CompensationId { get; set; }
        public System.DateTime Date { get; set; }
        public int SpentTime { get; set; }

        public virtual ICompensationDomain Compensation { get; set; }
    }
}

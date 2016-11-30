using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbsenceTracker.WebApi.ViewModels
{
    public class AbsenceView
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public string AssignedBy { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }

        public virtual ICollection<CompensationView> Compensations { get; set; }
        public virtual ICollection<SicknessView> Sicknesses { get; set; }
        public virtual ICollection<VacationView> Vacations { get; set; }
    }
}
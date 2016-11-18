using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbsenceTracker.WebApi.ViewModels
{
    public class AbsenceView
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string AssigneeId { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }

        public virtual AspNetUsersView AspNetUser { get; set; }
        public virtual AspNetUsersView AspNetUserAssignee { get; set; }
        public virtual ICollection<CompensationView> Compensation { get; set; }
        public virtual ICollection<SicknessView> Sickness { get; set; }
        public virtual ICollection<VacationView> Vacation { get; set; }
    }
}
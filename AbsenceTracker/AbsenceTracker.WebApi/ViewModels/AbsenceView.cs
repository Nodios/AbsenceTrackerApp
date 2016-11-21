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
    
        public virtual AspNetUserView AspNetUser { get; set; }
        public virtual AspNetUserView AspNetUserAssignee { get; set; }
        public virtual CompensationView Compensation { get; set; }
        public virtual SicknessView Sickness { get; set; }
        public virtual VacationView Vacation { get; set; }
    }
}
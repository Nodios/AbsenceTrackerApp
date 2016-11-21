using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbsenceTracker.WebApi.ViewModels
{
    public class AspNetUserRoleView
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<AspNetUserView> AspNetUsers { get; set; }
    }
}
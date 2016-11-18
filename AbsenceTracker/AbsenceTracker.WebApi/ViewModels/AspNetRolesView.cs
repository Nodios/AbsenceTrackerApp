using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbsenceTracker.WebApi.ViewModels
{
    public class AspNetRolesView
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<AspNetUsersView> AspNetUsers { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbsenceTracker.WebApi.ViewModels
{
    public class VacationView
    {
        string Id { get; set; }
        System.DateTime StartDate { get; set; }
        System.DateTime EndDate { get; set; }
        int Time { get; set; }
        int TimeLeft { get; set; }
        string AbsenceId { get; set; }
    }
}
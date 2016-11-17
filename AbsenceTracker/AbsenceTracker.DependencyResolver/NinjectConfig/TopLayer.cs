using AbsenceTracker.Service;
using AbsenceTracker.Service.Common;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.DependencyResolver.NinjectConfig
{
    public class TopLayer : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserService>();
            Bind<IAbsenceService>().To<AbsenceService>();
            Bind<IVacationService>().To<VacationService>();
            Bind<ISicknessService>().To<SicknessService>();
            Bind<ICompensationService>().To<CompensationService>();
            Bind<ICompensationEntryService>().To<CompensationEntryService>();
        }
    }
}

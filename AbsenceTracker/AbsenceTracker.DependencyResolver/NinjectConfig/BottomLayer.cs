using AbsenceTracker.DAL.Common.IDatabaseModels;
using AbsenceTracker.DAL.Database;
using AbsenceTracker.Model.Common.IDomainModels;
using AbsenceTracker.Model.DomainModels;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.DependencyResolver.NinjectConfig
{
    public class BottomLayer : NinjectModule
    {
        public override void Load()
        {
            //Binding database context
            Bind<IAbsenceTrackerEntities>().To<AbsenceTrackerEntities>();
        }
    }
}

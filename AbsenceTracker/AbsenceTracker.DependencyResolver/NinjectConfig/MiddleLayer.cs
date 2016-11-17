using AbsenceTracker.Repository;
using AbsenceTracker.Repository.Common;
using AbsenceTracker.Repository.Common.IGenericRepository;
using AbsenceTracker.Repository.Common.IRepository;
using AbsenceTracker.Repository.GenericRepository;
using AbsenceTracker.Repository.Repository;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.DependencyResolver.NinjectConfig
{
    public class MiddleLayer : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<IUnitOfWorkFactory>().To<UnitOfWorkFactory>();

            Bind<IGenericRepository>().To<GenericRepository>();

            Bind<IUserRepository>().To<UserRepository>();
            Bind<IAbsenceRepository>().To<AbsenceRepository>();
            Bind<IVacationRepository>().To<VacationRepository>();
            Bind<ISicknessRepository>().To<SicknessRepository>();
            Bind<ICompensationRepository>().To<CompensationRepository>();
            Bind<ICompensationEntryRepository>().To<CompensationEntryRepository>();

        }
    }
}

using AbsenceTracker.DAL.Database;
using AbsenceTracker.Model.Common.IDomainModels;
using AbsenceTracker.Model.DomainModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.DependencyResolver.MappingConfig
{
    public class MappingProfile : Profile
    {
        protected override void Configure()
        {
            //CompensationEntry database <-> CompensationEntry domain
            CreateMap<CompensationEntry, ICompensationEntryDomain>().PreserveReferences().ReverseMap().PreserveReferences();
            CreateMap<CompensationEntry,CompensationEntryDomain>().PreserveReferences().ReverseMap().PreserveReferences();

            CreateMap<Compensation, ICompensationDomain>().PreserveReferences().ReverseMap().PreserveReferences();
            CreateMap<Compensation, CompensationDomain>().PreserveReferences().ReverseMap().PreserveReferences();

            CreateMap<Absence, IAbsenceDomain>().PreserveReferences().ReverseMap().PreserveReferences();
            CreateMap<Absence, AbsenceDomain>().PreserveReferences().ReverseMap().PreserveReferences();

            CreateMap<Sickness, ISicknessDomain>().PreserveReferences().ReverseMap().PreserveReferences();
            CreateMap<Sickness, SicknessDomain>().PreserveReferences().ReverseMap().PreserveReferences();

            CreateMap<Vacation, IVacationDomain>().PreserveReferences().ReverseMap().PreserveReferences();
            CreateMap<Vacation, VacationDomain>().PreserveReferences().ReverseMap().PreserveReferences();

            CreateMap<AspNetUser, IAspNetUserDomain>().PreserveReferences().ReverseMap().PreserveReferences();
            CreateMap<AspNetUser, AspNetUserDomain>().PreserveReferences().ReverseMap().PreserveReferences();

            CreateMap<AspNetRole, IAspNetRoleDomain>().PreserveReferences().ReverseMap().PreserveReferences();
            CreateMap<AspNetRole, AspNetRoleDomain>().PreserveReferences().ReverseMap().PreserveReferences();

            CreateMap<AspNetUserClaim, IAspNetUserClaimDomain>().PreserveReferences().ReverseMap().PreserveReferences();
            CreateMap<AspNetUserClaim, AspNetUserClaimDomain>().PreserveReferences().ReverseMap().PreserveReferences();

            CreateMap<AspNetUserLogin, IAspNetUserLoginDomain>().PreserveReferences().ReverseMap().PreserveReferences();
            CreateMap<AspNetUserLogin, AspNetUserLoginDomain>().PreserveReferences().ReverseMap().PreserveReferences();

        }
    }
}

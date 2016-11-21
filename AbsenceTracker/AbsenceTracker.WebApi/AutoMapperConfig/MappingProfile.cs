using AbsenceTracker.Model.Common.IDomainModels;
using AbsenceTracker.Model.DomainModels;
using AbsenceTracker.WebApi.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbsenceTracker.WebApi.AutoMapperConfig
{
    public class MappingProfile : Profile
    {
        protected override void Configure()
        {
            //CreateMap<destination, source>().ReverseMap();
            //CompensationEntry domain <-> CompensationEntry view
            CreateMap<CompensationEntryView, ICompensationEntryDomain>().PreserveReferences().ReverseMap().PreserveReferences();
            CreateMap<CompensationEntryView, CompensationEntryDomain>().PreserveReferences().ReverseMap().PreserveReferences();

            CreateMap<CompensationView, ICompensationDomain>().PreserveReferences().ReverseMap().PreserveReferences();
            CreateMap<CompensationView, CompensationDomain>().PreserveReferences().ReverseMap().PreserveReferences();

            CreateMap<AbsenceView, IAbsenceDomain>().PreserveReferences().ReverseMap().PreserveReferences();
            CreateMap<AbsenceView, AbsenceDomain>().PreserveReferences().ReverseMap().PreserveReferences();

            CreateMap<SicknessView, ISicknessDomain>().PreserveReferences().ReverseMap().PreserveReferences();
            CreateMap<SicknessView, SicknessDomain>().PreserveReferences().ReverseMap().PreserveReferences();

            CreateMap<VacationView, IVacationDomain>().PreserveReferences().ReverseMap().PreserveReferences();
            CreateMap<VacationView, VacationDomain>().PreserveReferences().ReverseMap().PreserveReferences();

            CreateMap<AspNetUserView, IAspNetUserDomain>().PreserveReferences().ReverseMap().PreserveReferences();
            CreateMap<AspNetUserView, AspNetUserDomain>().PreserveReferences().ReverseMap().PreserveReferences();

            CreateMap<AspNetUserRoleView, IAspNetUserRoleDomain>().PreserveReferences().ReverseMap().PreserveReferences();
            CreateMap<AspNetUserRoleView, AspNetUserRoleDomain>().PreserveReferences().ReverseMap().PreserveReferences();

            CreateMap<AspNetUserClaimView, IAspNetUserClaimDomain>().PreserveReferences().ReverseMap().PreserveReferences();
            CreateMap<AspNetUserClaimView, AspNetUserClaimDomain>().PreserveReferences().ReverseMap().PreserveReferences();

            CreateMap<AspNetUserLoginView, IAspNetUserLoginDomain>().PreserveReferences().ReverseMap().PreserveReferences();
            CreateMap<AspNetUserLoginView, AspNetUserLoginDomain>().PreserveReferences().ReverseMap().PreserveReferences();
        }
    }
}
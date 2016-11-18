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
            CreateMap<CompensationEntryView, CompensationEntryDomain>().ReverseMap();
            CreateMap<CompensationEntryView, ICompensationEntryDomain>().ReverseMap();

            


        }
    }
}
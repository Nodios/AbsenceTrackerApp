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
            //CreateMap<destination, source>().ReverseMap();
            //CompensationEntry database <-> CompensationEntry domain
            CreateMap<CompensationEntry, ICompensationEntryDomain>().ReverseMap();
            CreateMap<CompensationEntryDomain, CompensationEntry>().ReverseMap();
            CreateMap<ICompensationEntryDomain, CompensationEntry>().ReverseMap();

        }
    }
}

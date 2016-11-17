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
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace AbsenceTracker.WebApi.AutoMapperConfig
{
    public static class MapperInit
    {
        public static void Init()
        {
            Mapper.Initialize(cfg =>
           cfg.AddProfiles(new[] {
                typeof(DependencyResolver.MappingConfig.MappingProfile),
                typeof(MappingProfile)
               })
           );
        }
    }
}
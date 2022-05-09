using System;
using AutoMapper;
using Organimmo.SDK;


namespace Organimmo.SDK.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ConfigureMappings();
        }

        private void ConfigureMappings()
        {
            //CreateMap<Item, ItemDto>()
            //    .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
            //    .ReverseMap();
        }
    }
}



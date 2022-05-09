using System;

namespace Organimmo.Bl.Profiles
{
    public class MappingProfile
    {
        public MappingProfile()
        {
            ConfigureMappings();
        }

        private void ConfigureMappings()
        {
            CreateMap<Item, ItemDto>()
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.BaseText, opt => opt.MapFrom(src => src.BaseText))
                .ForMember(dest => dest.CurrentText, opt => opt.MapFrom(src => src.CurrentText))
                .ReverseMap();
        }
    }
}



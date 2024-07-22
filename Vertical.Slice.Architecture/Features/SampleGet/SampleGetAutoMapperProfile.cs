using AutoMapper;

namespace Vertical.Slice.Architecture.Features.SampleGet
{
    public class SampleGetAutoMapperProfile : Profile
    {
        public SampleGetAutoMapperProfile()
        {
            this.CreateMap<SampleGetRequest, SampleGetQuery>()
                .ForMember(dest => dest.QueryParam1, opt => opt.MapFrom(src => src.QueryParam1))
                .ForMember(dest => dest.QueryParam2, opt => opt.MapFrom(src => src.QueryParam2))
                .ForMember(dest => dest.RouteParam1, opt => opt.MapFrom(src => src.RouteParam1))
                .ForMember(dest => dest.RouteParam2, opt => opt.MapFrom(src => src.RouteParam2))
                ;
        }
    }
}

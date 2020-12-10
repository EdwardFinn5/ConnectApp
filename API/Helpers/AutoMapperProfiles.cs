using System.Linq;
using API.DTOs;
using API.Entities;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>()
                .ForMember(dest => dest.PhotoUrl, opt => opt
                    .MapFrom(src => src.Photos.FirstOrDefault(x => x.IsMain).StudentUrl))
                .ForMember(dest => dest.LogoUrl, opt => opt
                    .MapFrom(src => src.Photos.FirstOrDefault(x => x.IsMain).LogoUrl))
                .ForMember(dest => dest.ClassYear, opt => opt
                    .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).ClassYear))
                .ForMember(dest => dest.Company, opt => opt
                    .MapFrom(src => src.EmpOpps.FirstOrDefault(x => x.IsActive).Company))
                .ForMember(dest => dest.Position, opt => opt
                    .MapFrom(src => src.EmpOpps.FirstOrDefault(x => x.IsActive).Position))
                .ForMember(dest => dest.Major, opt => opt
                    .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).Major))
                 .ForMember(dest => dest.WorkPlus, opt => opt
                    .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).WorkPlus));
            CreateMap<Photo, PhotoDto>();
            CreateMap<CollegePrep, CollegePrepDto>();
            CreateMap<EmpOpp, EmpOppDto>();
        }
    }
}
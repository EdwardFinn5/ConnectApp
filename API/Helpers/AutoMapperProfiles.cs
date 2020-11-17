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
                .ForMember(dest => dest.ClassYear, opt => opt
                    .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).ClassYear))
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
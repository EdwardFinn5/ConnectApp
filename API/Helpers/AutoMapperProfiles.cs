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
                .ForMember(dest => dest.PhotUrl, opt => opt.MapFrom(src => 
                    src.Photos.FirstOrDefault(x => x.IsMain).StudentUrl));
            CreateMap<Photo, PhotoDto>();
            CreateMap<CollegePrep, CollegePrepDto>();
            CreateMap<EmpOpp, EmpOppDto>();
        }
    }
}
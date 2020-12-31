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
                    .MapFrom(src => src.Photos.FirstOrDefault(x => x.IsMainLogo).LogoUrl))
                .ForMember(dest => dest.ClassYear, opt => opt
                    .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).ClassYear))
                .ForMember(dest => dest.Company, opt => opt
                    .MapFrom(src => src.EmpOpps.FirstOrDefault(x => x.IsActive).Company))
                .ForMember(dest => dest.Position, opt => opt
                    .MapFrom(src => src.EmpOpps.FirstOrDefault(x => x.IsActive).Position))
                .ForMember(dest => dest.Major, opt => opt
                    .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).Major))
                 .ForMember(dest => dest.Hometown, opt => opt
                    .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).Hometown))
                .ForMember(dest => dest.AcademicPlus, opt => opt
                    .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).AcademicPlus))
                .ForMember(dest => dest.WorkPlus, opt => opt
                    .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).WorkPlus))
                .ForMember(dest => dest.College, opt => opt
                    .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).College))    
                .ForMember(dest => dest.DreamJob, opt => opt
                    .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).DreamJob));

            CreateMap<Photo, PhotoDto>();
            CreateMap<CollegePrep, CollegePrepDto>();
            CreateMap<EmpOpp, EmpOppDto>();
        }
    }
}
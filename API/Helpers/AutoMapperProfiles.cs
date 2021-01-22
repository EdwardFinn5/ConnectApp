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
                .ForMember(dest => dest.AcademicPlus, opt => opt
                    .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).AcademicPlus))
                .ForMember(dest => dest.WorkPlus, opt => opt
                    .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).WorkPlus))
                .ForMember(dest => dest.DreamJob, opt => opt
                    .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).DreamJob));

            CreateMap<ColUser, ColMemberDto>()
                .ForMember(dest => dest.ColUrl, opt => opt
                    .MapFrom(src => src.ColPhotos.FirstOrDefault(x => x.IsMainCol).ColUrl))
                .ForMember(dest => dest.HsStudentUrl, opt => opt
                    .MapFrom(src => src.ColPhotos.FirstOrDefault(x => x.IsMainHs).HsStudentUrl));
            
            CreateMap<Photo, PhotoDto>();
            CreateMap<CollegePrep, CollegePrepDto>();
            CreateMap<EmpOpp, EmpOppDto>();
            CreateMap<ColPhoto, ColPhotoDto>();
            CreateMap<College, CollegeDto>();
            CreateMap<HsPrep, HsPrepDto>();

        }
    }
}
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
                .ForMember(dest => dest.StudentUrl, opt => opt
                    .MapFrom(src => src.Photos.FirstOrDefault(x => x.IsMain).StudentUrl))
                .ForMember(dest => dest.LogoUrl, opt => opt
                    .MapFrom(src => src.Photos.FirstOrDefault(x => x.IsMainLogo).LogoUrl))
                .ForMember(dest => dest.HrUrl, opt => opt
                    .MapFrom(src => src.Photos.FirstOrDefault(x => x.IsMainHr).HrUrl))
                .ForMember(dest => dest.AcademicPlus, opt => opt
                    .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).AcademicPlus))
                .ForMember(dest => dest.GPA, opt => opt
                    .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).GPA))
                .ForMember(dest => dest.WorkPlus, opt => opt
                    .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).WorkPlus))
                .ForMember(dest => dest.DreamJob, opt => opt
                    .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).DreamJob))
                .ForMember(dest => dest.Athletics, opt => opt
                    .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).Athletics))
                .ForMember(dest => dest.Arts, opt => opt
                    .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).Arts))
                .ForMember(dest => dest.ExtraCurricular, opt => opt
                    .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).ExtraCurricular))
                .ForMember(dest => dest.BestEmail, opt => opt
                    .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).BestEmail))
                .ForMember(dest => dest.BestPhone, opt => opt
                    .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).BestPhone))
                .ForMember(dest => dest.LookingFor, opt => opt
                    .MapFrom(src => src.EmpOpps.FirstOrDefault(x => x.IsActive).LookingFor))
                .ForMember(dest => dest.HowToApply, opt => opt
                    .MapFrom(src => src.EmpOpps.FirstOrDefault(x => x.IsActive).HowToApply))
                .ForMember(dest => dest.ApplyEmail, opt => opt
                    .MapFrom(src => src.EmpOpps.FirstOrDefault(x => x.IsActive).ApplyEmail))
                .ForMember(dest => dest.Contact, opt => opt
                    .MapFrom(src => src.EmpOpps.FirstOrDefault(x => x.IsActive).Contact))
                .ForMember(dest => dest.CompanyDescription, opt => opt
                    .MapFrom(src => src.EmpOpps.FirstOrDefault(x => x.IsActive).CompanyDescription))
                .ForMember(dest => dest.PositionDescription, opt => opt
                    .MapFrom(src => src.EmpOpps.FirstOrDefault(x => x.IsActive).PositionDescription))
                .ForMember(dest => dest.ContactTitle, opt => opt
                .MapFrom(src => src.EmpOpps.FirstOrDefault(x => x.IsActive).ContactTitle));
                    

            CreateMap<ColUser, ColMemberDto>()
                .ForMember(dest => dest.ColUrl, opt => opt
                    .MapFrom(src => src.ColPhotos.FirstOrDefault(x => x.IsMainCol).ColUrl))
                .ForMember(dest => dest.HsStudentUrl, opt => opt
                    .MapFrom(src => src.ColPhotos.FirstOrDefault(x => x.IsMainHs).HsStudentUrl))
                .ForMember(dest => dest.AdminUrl, opt => opt
                    .MapFrom(src => src.ColPhotos.FirstOrDefault(x => x.IsMainAdmin).AdminUrl))
                .ForMember(dest => dest.AdminContact, opt => opt
                    .MapFrom(src => src.Colleges.FirstOrDefault(x => x.IsActive).AdminContact))
                .ForMember(dest => dest.CollegeDescription, opt => opt
                    .MapFrom(src => src.Colleges.FirstOrDefault(x => x.IsActive).CollegeDescription))
                .ForMember(dest => dest.CollegeStreet, opt => opt
                    .MapFrom(src => src.Colleges.FirstOrDefault(x => x.IsActive).CollegeStreet))
                .ForMember(dest => dest.CollegeCity, opt => opt
                    .MapFrom(src => src.Colleges.FirstOrDefault(x => x.IsActive).CollegeCity))
                .ForMember(dest => dest.CollegeState, opt => opt
                    .MapFrom(src => src.Colleges.FirstOrDefault(x => x.IsActive).CollegeState))
                .ForMember(dest => dest.CollegeZip, opt => opt
                    .MapFrom(src => src.Colleges.FirstOrDefault(x => x.IsActive).CollegeZip))
                .ForMember(dest => dest.CollegeEmail, opt => opt
                    .MapFrom(src => src.Colleges.FirstOrDefault(x => x.IsActive).CollegeEmail))
                .ForMember(dest => dest.CollegeWebsite, opt => opt
                    .MapFrom(src => src.Colleges.FirstOrDefault(x => x.IsActive).CollegeWebsite))
                .ForMember(dest => dest.CollegeVirtual, opt => opt
                    .MapFrom(src => src.Colleges.FirstOrDefault(x => x.IsActive).CollegeVirtual))
                .ForMember(dest => dest.GPA, opt => opt
                    .MapFrom(src => src.HsPreps.FirstOrDefault(x => x.IsActive).GPA))
                .ForMember(dest => dest.ProposedMajor, opt => opt
                    .MapFrom(src => src.HsPreps.FirstOrDefault(x => x.IsActive).ProposedMajor))
                .ForMember(dest => dest.ExtraCurricular, opt => opt
                    .MapFrom(src => src.HsPreps.FirstOrDefault(x => x.IsActive).ExtraCurricular))
                .ForMember(dest => dest.DreamJob, opt => opt
                    .MapFrom(src => src.HsPreps.FirstOrDefault(x => x.IsActive).DreamJob))
                .ForMember(dest => dest.AdminTitle, opt => opt
                    .MapFrom(src => src.Colleges.FirstOrDefault(x => x.IsActive).AdminTitle));

            // CreateMap<MemberColUpdateDto, AppUser>();

            // CreateMap<AppUser, MemberColUpdateDto>().ReverseMap();
            //   .ForMember(dest => dest.Athletics, opt => opt
            //         .MapFrom(src => src.CollegePreps.FirstOrDefault(x => x.IsActive).Athletics)).ReverseMap();
            //    .ForMember(dest => dest.StudentUrl, opt => opt
            //         .MapFrom(src => src.Photos.FirstOrDefault(x => x.IsMain).StudentUrl)).ReverseMap();

             
            CreateMap<MemberUpdateDto, AppUser>();
            CreateMap<Photo, PhotoDto>();
            CreateMap<CollegePrep, CollegePrepDto>();
            CreateMap<EmpOpp, EmpOppDto>();
            CreateMap<ColPhoto, ColPhotoDto>();
            CreateMap<College, CollegeDto>();
            CreateMap<HsPrep, HsPrepDto>();
        }
    }
}
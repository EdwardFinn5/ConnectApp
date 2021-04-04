using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Extensions;
using API.Helpers;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly IMapper _mapper;
        private readonly IPhotoService _photoService;
        private readonly IUnitOfWork _unitOfWork;

        public UsersController(IMapper mapper, IPhotoService photoService, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _photoService = photoService;
            _mapper = mapper;
        }

        [HttpGet] // new get users after adding UserParams
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers([FromQuery] UserParams userParams)
        {
            var appUserType = await _unitOfWork.UserRepository.GetUserAppUserType(User.GetUserName());
            userParams.CurrentUsername = User.GetUserName();

            if (string.IsNullOrEmpty(userParams.AppUserType))
                userParams.AppUserType = appUserType == "ColStudent" ? "EmpHr" : "ColStudent";

            var users = await _unitOfWork.UserRepository.GetMembersAsync(userParams);

            Response.AddPaginationHeader(users.CurrentPage,
                                    users.PageSize,
                                    users.TotalCount,
                                    users.TotalPages);

            return Ok(users);
        }

        // [Authorize(Roles = "Member")]
        [HttpGet("{username}", Name = "GetUser")]
        public async Task<ActionResult<MemberDto>> GetUser(string username)
        {
            var user = await _unitOfWork.UserRepository.GetMemberAsync(username);

            return Ok(user);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateUser(MemberUpdateDto memberUpdateDto)
        {
            var user = await _unitOfWork.UserRepository.GetUserByUsernameAsync(User.GetUserName());

            _mapper.Map(memberUpdateDto, user);

            _unitOfWork.UserRepository.Update(user);

            // var collegePrep = new CollegePrep
            // {
            //     AcademicPlus = memberUpdateDto.AcademicPlus
            // };

            // user.CollegePreps.Add(collegePrep);

            // user.CollegePreps.a Entry(user.CollegePreps.AcademicPlus).State = EntityState.Modified;

            // _context.Entry(user).State = EntityState.Modified;

            if (await _unitOfWork.Complete()) return NoContent();

            return BadRequest("Failed to update user");
        }

        [HttpPost("add-photo")]
        public async Task<ActionResult<PhotoDto>> AddPhoto(IFormFile file)
        {
            var user = await _unitOfWork.UserRepository.GetUserByUsernameAsync(User.GetUserName());

            var result = await _photoService.AddPhotoAsync(file);

            if (result.Error != null) return BadRequest(result.Error.Message);

            var photo = new Photo
            {
                StudentUrl = null,
                LogoUrl = null
            };

            if (user.AppUserType == "ColStudent")
            {
                photo.StudentUrl = result.SecureUrl.AbsoluteUri;
                photo.PublicId = result.PublicId;
            };

            if (user.AppUserType == "EmpHr")
            {
                photo.LogoUrl = result.SecureUrl.AbsoluteUri;
                photo.PublicId = result.PublicId;
            };

            if (user.Photos.Count == 0 && user.AppUserType == "ColStudent")
            {
                photo.IsMain = true;
            }

            if (user.Photos.Count == 0 && user.AppUserType == "EmpHr")
            {
                photo.IsMainLogo = true;
            }

            user.Photos.Add(photo);

            if (await _unitOfWork.Complete())
            {
                // return _mapper.Map<PhotoDto>(photo);
                // return CreatedAtRoute("GetUser", _mapper.Map<PhotoDto>(photo)); 
                return CreatedAtRoute("GetUser", new { username = user.UserName }, _mapper.Map<PhotoDto>(photo)); // used 3rd overload which 
                // has the following parameters: string routename, object routeValues, object value
            }

            return BadRequest("Problem adding photo");
        }

        [HttpPut("set-main-photo/{photoId}")]
        public async Task<ActionResult> SetMainPhoto(int photoId)
        {
            var user = await _unitOfWork.UserRepository.GetUserByUsernameAsync(User.GetUserName());

            var photo = user.Photos.FirstOrDefault(x => x.Id == photoId);

            if (user.AppUserType == "ColStudent")
            {
                if (photo.IsMain) return BadRequest("This is already your main photo");

                var currentMain = user.Photos.FirstOrDefault(x => x.IsMain);

                if (currentMain != null)
                {
                    currentMain.IsMain = false;
                    photo.IsMain = true;
                }
            }

            if (user.AppUserType == "EmpHr")
            {
                if (photo.IsMain) return BadRequest("This is already your main logo");

                var currentMain = user.Photos.FirstOrDefault(x => x.IsMainLogo);

                if (currentMain != null)
                {
                    currentMain.IsMainLogo = false;
                    photo.IsMainLogo = true;
                }
            }

            if (await _unitOfWork.Complete()) return NoContent();

            return BadRequest("Failed to set main photo");
        }

        [HttpDelete("delete-photo/{photoId}")]
        public async Task<ActionResult> DeletePhoto(int photoId)
        {
            var user = await _unitOfWork.UserRepository.GetUserByUsernameAsync(User.GetUserName());

            var photo = user.Photos.FirstOrDefault(x => x.Id == photoId);

            if (photo == null)
            {
                return NotFound();
            }

            if (photo.IsMain)
            {
                return BadRequest("You cannot delete your main photo");
            }

            if (photo.IsMainLogo)
            {
                return BadRequest("You cannot delete your main logo");
            }

            if (photo.PublicId != null)
            {
                var result = await _photoService.DeletePhotoAsync(photo.PublicId);
                if (result.Error != null)
                {
                    return BadRequest(result.Error.Message);
                }
            }

            user.Photos.Remove(photo);

            if (await _unitOfWork.Complete()) return Ok();

            return BadRequest("Failed to delete the photo/logo");
        }
    }
}
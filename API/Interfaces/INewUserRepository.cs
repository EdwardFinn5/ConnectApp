using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface INewUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetNewUsersAsync();
        Task<AppUser> GetNewUserByIdAsync(int id);
        Task<AppUser> GetNewUserByUserNameAsync(string username);
        // the next two tasks added with video 97
        Task<IEnumerable<MemberDto>> GetNewMembersAsync();
        Task<MemberDto> GetNewMemberAsync(string username);
    }
}
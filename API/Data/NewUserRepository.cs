using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class NewUserRepository : INewUserRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public NewUserRepository(DataContext context,
                                IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

    public async Task<MemberDto> GetNewMemberAsync(string username)
    {
        return await _context.Users
            .Where(x => x.UserName == username)
            .ProjectTo<MemberDto>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync();
    }

    public async Task<IEnumerable<MemberDto>> GetNewMembersAsync()
    {
        return await _context.Users
            .ProjectTo<MemberDto>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }


    public Task<AppUser> GetNewUserByIdAsync(int id)
    {
        throw new System.NotImplementedException();
    }

    // public async Task<AppUser> GetNewUserByIdAsync(int id)
    // {
    //     return await _context.Users
    //         .Include(p => p.Photos)
    //         .Include(c => c.CollegePreps)
    //         .Include(e => e.EmpOpps)
    //         .SingleOrDefaultAsync(x => x.Id == id);
    // }

    public async Task<AppUser> GetNewUserByUserNameAsync(string username)
    {
        return await _context.Users
            .Include(p => p.Photos)
            .Include(c => c.CollegePreps)
            .Include(e => e.EmpOpps)
            .SingleOrDefaultAsync(x => x.UserName == username);
    }

    public async Task<IEnumerable<AppUser>> GetNewUsersAsync()
    {
        return await _context.Users
            .Include(p => p.Photos)
            .Include(c => c.CollegePreps)
            .Include(e => e.EmpOpps)
            .ToListAsync();
    }

    public async Task<bool> SaveAllAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public void Update(AppUser user)
    {
        _context.Entry(user).State = EntityState.Modified;
    }
}
}
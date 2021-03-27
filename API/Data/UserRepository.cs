using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Helpers;
using API.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public UserRepository(DataContext context,
                             IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<MemberDto> GetMemberAsync(string username)
        {
            return await _context.Users
                .Where(x => x.UserName == username)
                .ProjectTo<MemberDto>(_mapper.ConfigurationProvider)
                .SingleOrDefaultAsync();
        }

        // public async Task<IEnumerable<MemberDto>> GetMembersAsync()
        // {
        //     return await _context.Users
        //         .ProjectTo<MemberDto>(_mapper.ConfigurationProvider)
        //         .ToListAsync();
        // }

        public async Task<PagedList<MemberDto>> GetMembersAsync(UserParams userParams) //made changes after adding UserParams
        {
            var query = _context.Users.AsQueryable();

            query = query.Where(u => u.UserName != userParams.CurrentUsername);
            query = query.Where(u => u.AppUserType == userParams.AppUserType);

            // query = query.Where(u => u.Position == userParams.Position);
            // query = query.Where(u => u.Major == userParams.Major);

            query = userParams.OrderBy switch
            {
                "created" => query.OrderByDescending(u => u.Created),
                _ => query.OrderByDescending(u => u.LastActive)
            };

            return await PagedList<MemberDto>
                .CreateAsync(query.ProjectTo<MemberDto>(_mapper.ConfigurationProvider)
                .AsNoTracking(),
                userParams.PageNumber,
                userParams.PageSize
                );
        }

        public async Task<string> GetUserAppUserType(string username)
        {
            return await _context.Users
                .Where(x => x.UserName == username)
                .Select(x => x.AppUserType).FirstOrDefaultAsync();
        }

        public async Task<AppUser> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<AppUser> GetUserByUsernameAsync(string username)
        {
            return await _context.Users
                .Include(p => p.Photos)
                .Include(c => c.CollegePreps)
                .Include(e => e.EmpOpps)
                .SingleOrDefaultAsync(x => x.UserName == username);
        }

        public async Task<IEnumerable<AppUser>> GetUsersAsync()
        {
            return await _context.Users
                .Include(p => p.Photos)
                .Include(c => c.CollegePreps)
                .Include(e => e.EmpOpps)
                .ToListAsync();
        }
        // deleted this save method after creating unit of work
        // public async Task<bool> SaveAllAsync()
        // {
        //     return await _context.SaveChangesAsync() > 0;
        // }

        public void Update(AppUser user)
        {
            _context.Entry(user).State = EntityState.Modified;
        }
    }
}
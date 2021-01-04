using DataLayer.Models;
using DataLayer.Services;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class SQLFriendRepository : IFriendRepository
    {
        private IApplicationDbContext _context;

        public SQLFriendRepository(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Friend> Add(Friend friend)
        {
            _context.Friends.Add(friend);
            await _context.SaveChangesAsync();
            return friend;
        }

        public async Task<Friend> Delete(int id)
        {
            var friend = await _context.Friends.Where(m => m.Id == id).FirstOrDefaultAsync();
            _context.Friends.Remove(friend);
            await _context.SaveChangesAsync();
            return friend;
        }

        public async Task<IEnumerable<Friend>> GetAllFriends()
        {
            var friendList = await _context.Friends.OrderBy(m => m.Id).ToListAsync();
            return friendList;
        }

        public async Task<Friend> GetFriend(int id)
        {
            var friend = await _context.Friends.Where(m => m.Id == id).FirstOrDefaultAsync();
            return friend;
        }

        public Friend Update(Friend friend)
        {
            var friendUpdate = _context.Friends.Attach(friend);
            friendUpdate.State = EntityState.Modified;
            _context.SaveChanges();
            return friend;
        }
    }
}

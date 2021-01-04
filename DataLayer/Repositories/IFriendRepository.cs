using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public interface IFriendRepository
    {
        Task<Friend> Add(Friend friend);
        Task<Friend> Delete(int id);
        Friend Update(Friend friend);
        Task<Friend> GetFriend(int id);
        Task<IEnumerable<Friend>> GetAllFriends();


    }
}

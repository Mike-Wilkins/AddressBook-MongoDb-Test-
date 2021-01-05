using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public interface IFriendMongoRepository
    {
        Task<FriendMongo> Add(FriendMongo friend);
        Task<FriendMongo> Delete(int id);
        FriendMongo Update(FriendMongo friend);
        Task<FriendMongo> GetFriend(int id);
        Task<IEnumerable<FriendMongo>> GetAllFriends();
    }
}

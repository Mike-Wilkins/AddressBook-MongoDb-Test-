using DataLayer.Models;
using DataLayer.Services;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class MongoFriendRepository : IFriendMongoRepository
    {
        private readonly IMongoCollection<FriendMongo> _context;

        public MongoFriendRepository(IAddressBookDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _context = database.GetCollection<FriendMongo>(settings.AddressBookCollectionName);

        }



        public Task<FriendMongo> Add(FriendMongo friend)
        {
            throw new NotImplementedException();
        }

        public Task<FriendMongo> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FriendMongo>> GetAllFriends()
        {
            throw new NotImplementedException();
        }

        public Task<FriendMongo> GetFriend(int id)
        {
            throw new NotImplementedException();
        }

        public FriendMongo Update(FriendMongo friend)
        {
            throw new NotImplementedException();
        }
    }
}

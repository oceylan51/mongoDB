using Data.Repository;
using Entity;
using MongoDB.Driver;


namespace Data.UnitOfWork
{
    public class UnitOfWork
    {
        private IMongoClient _client;
        private IMongoDatabase _mongoDatabase;
        private readonly IMongoCollection<Users> _collection;
        protected Repository<Users> _users;

        public UnitOfWork()
        {
            _client = new MongoClient("mongodb+srv://ceylan:1234@cluster0.ozwgh7o.mongodb.net/myliba");
            _mongoDatabase = _client.GetDatabase("myliba");
            _collection = _mongoDatabase.GetCollection<Users>("users");

        }
        public Repository<Users> Users
        {
            get
            {
                if (_users == null)
                    _users = new Repository<Users>(_mongoDatabase, "users");
                
                return _users;
            }
        }
    }
}

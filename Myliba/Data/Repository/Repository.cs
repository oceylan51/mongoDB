using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class Repository<T> where T : class
    {
        private IMongoDatabase _mongoDatabase;
        private string _tableName;
        private readonly IMongoCollection<T> _collection;

        public Repository(IMongoDatabase mongoDatabase, string tableName)
        {
            _mongoDatabase = mongoDatabase;
            _tableName = tableName;
            _collection = _mongoDatabase.GetCollection<T>(tableName);
        }
       
        public async Task<IEnumerable<T>> GetAll()
        {
            var filter = Builders<T>.Filter.Where(r => true);
            var options = new FindOptions<T> { Limit = 10 };

            return await _collection.FindAsync<T>(filter, options).Result.ToListAsync();
        }
        public async Task<T> Get(Expression<Func<T, ObjectId>> queryExpression, ObjectId id)
        {
            var filter = Builders<T>.Filter.Eq(queryExpression, id);
            return await _collection.FindSync<T>(filter).FirstOrDefaultAsync();
        }
        
        public async Task Add(T entity)
        {
            await _collection.InsertOneAsync(entity);
        }
        public async Task Update(Expression<Func<T, ObjectId>> queryExpression, ObjectId id, T entity)
        {
            var filter = Builders<T>.Filter.Eq(queryExpression, id);
            await _collection.ReplaceOneAsync(filter, entity);
        }
        public async Task Delete(Expression<Func<T, ObjectId>> queryExpression, ObjectId id)
        {
            var filter = Builders<T>.Filter.Eq(queryExpression, id);
            await _collection.DeleteOneAsync(filter);
        }
    }
}

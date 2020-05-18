using MongoDB.Bson;
using MongoDB.Driver;
using pracitices.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseRepository
{
    public class BaseRepository<TModel> : IBaseRepository<TModel> where TModel : MongoBaseModel
    {
        private readonly IMongoCollection<TModel> _collection;
        public BaseRepository(IBookstoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _collection = database.GetCollection<TModel>(settings.BooksCollectionName);
        }
        public  List<TModel> GetList()
        {
            return _collection.Find(book => true).ToList();
        }

        public  TModel GetById(string id)
        {
            var docId = new ObjectId(id);
            return _collection.Find<TModel>(m => m.Id == docId).FirstOrDefault();
        }

        public  TModel Create(TModel model)
        {
            _collection.InsertOne(model);
            return model;
        }

        public  void Update(string id, TModel model)
        {
            var docId = new ObjectId(id);
            _collection.ReplaceOne(m => m.Id == docId, model);
        }

        public  void Delete(TModel model)
        {
            _collection.DeleteOne(m => m.Id == model.Id);
        }

        public  void Delete(string id)
        {
            var docId = new ObjectId(id);
            _collection.DeleteOne(m => m.Id == docId);
        }
    }
}

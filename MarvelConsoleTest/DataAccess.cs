using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelConsoleTest
{
    public class DataAccess
    {
        IMongoDatabase db;

        public DataAccess(string dbName)
        {
            MongoClient client = new MongoClient();
            db = client.GetDatabase(dbName);
        }

        public void WriteNew<T>(T model, string table)
        {
            db.GetCollection<T>(table).InsertOne(model);
        }
    
        public List<T> ReadByType<T>(string table, string type)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Classification", type);
            var query = collection.Find(filter).ToList();

            if(query.Count() == 0)
            {
                filter = Builders<T>.Filter.Eq("CardInfo.Classification", type);
                query = collection.Find(filter).ToList();
            }

            return query;
        }

        public T ReadByName<T>(string table, string name)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Name", name);
            var query = collection.Find(filter).FirstOrDefault();

            if (query == null)
            {
                filter = Builders<T>.Filter.Eq("CardInfo.Name", name);
                query = collection.Find(filter).FirstOrDefault();
            }

            return query;
        }

        public List<T> ReadByAttribute<T>(string table, string att)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Teams", att);
            var query = collection.Find(filter).ToList();

            if (query.Count() == 0)
            {
                filter = Builders<T>.Filter.Eq("Classes", att);
                query = collection.Find(filter).ToList();
            }

            return query;
        }

        public List<string> ListCollections()
        {
            return db.ListCollectionNames().ToList();
        }
    }
}

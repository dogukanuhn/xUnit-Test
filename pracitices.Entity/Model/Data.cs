using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace pracitices.Entity.Model
{
    public class Data : MongoBaseModel
    {


        [BsonElement("Name")]
        public string BookName { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }
    }
}
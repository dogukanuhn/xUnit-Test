using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace pracitices.Entity.Model
{
    public abstract class MongoBaseModel
    {
        public ObjectId Id { get; set; }
    }
}

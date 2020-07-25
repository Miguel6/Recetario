using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Prueba
    {
        [BsonId]
        public string _id { get; set; }
        public string prueba { get; set; }
    }
}

using System;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DataAccess.MongoDB
{
    public class Connection
    {

        public long ConnectToMongoDBAsync()
        {
            //user: userTest
            //pass: pas123

            MongoClient dbClient = new MongoClient("mongodb+srv://userTest:pass123@Recetario.zqlup.azure.mongodb.net/Recetario?retryWrites=true&w=majority");

            var database = dbClient.GetDatabase("Recetas");
            var collection = database.GetCollection<BsonDocument>("Recetas");

            return collection.EstimatedDocumentCountAsync().Result;
        }
    }
}

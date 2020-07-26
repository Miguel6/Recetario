using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace DataAccess.MongoDB
{
    public class DatabaseConnection
    {
        private readonly IConfiguration configuration;
        public DatabaseConnection(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        private MongoClient GetMongoClient()
        {
            var user = configuration["DatabaseConnection:User"];
            var password = configuration["DatabaseConnection:Password"];
            var database = configuration["DatabaseConnection:Database"];
            var connectionString = $"mongodb+srv://{user}:{password}@recetario.zqlup.azure.mongodb.net/{database}?retryWrites=true&w=majority";

            return new MongoClient(connectionString);

            //var db = dbClient.GetDatabase("Recetas");
            //var collection = db.GetCollection<Receta>("Receta");
            //collection.InsertOneAsync(new Receta { Dificultad = new Dificultad { Descripcion = "Soy otra dificultad" }, Nombre = "Receta 2" });

            //return collection.EstimatedDocumentCountAsync().Result;
        }

        public IMongoCollection<T> GetCollection<T>()
        {
            var name = typeof(T).Name;

            return GetMongoClient().GetDatabase(name).GetCollection<T>(name);
        }
    }
}

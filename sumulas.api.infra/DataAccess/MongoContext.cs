using Microsoft.Extensions.Configuration;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using sumulas.api.domain.Entities.Basicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace sumulas.api.infra.DataAccess
{
    public class MongoContext
    {
        private readonly IMongoDatabase _database;
        public MongoContext(IConfiguration configuration)
        {
            //var client = new MongoClient(configuration.GetConnectionString("sumulas"));
            var client = new MongoClient("mongodb://felipe:FelipeMongo@@1@cluster-sumulas-mfoia.mongodb.net/test?retryWrites=true&ssl=true");
            //var database = client.GetDatabase("test");

            _database = client.GetDatabase("sumulas");
            //_books = database.GetCollection<Campeonato>("campeonatos");
        }

        private static void RegisterClassMap(){
            BsonClassMap.RegisterClassMap<Campeonatos>(cm =>
            {
                cm.AutoMap();
                cm.SetIgnoreExtraElements(true); //Serve para ignorar propriedades que nao foram encontradas               
            });
        }

        internal IMongoCollection<Campeonatos> Campeonatos =>
            _database.GetCollection<Campeonatos>((nameof(Campeonatos).ToLower()));

    }
}

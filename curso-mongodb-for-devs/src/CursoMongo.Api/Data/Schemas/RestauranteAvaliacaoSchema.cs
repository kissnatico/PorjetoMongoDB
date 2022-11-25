using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CursoMongo.Api.Data.Schemas
{
    public class RestauranteAvaliacaoSchema
    {
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonId]
        public string Id { get; set; }
        public double MediaEstrelas { get; set; }
        public List<RestauranteSchema> Restaurante { get; set; }
        public List<AvaliacaoSchema> Avaliacoes { get; set; }
    }
}
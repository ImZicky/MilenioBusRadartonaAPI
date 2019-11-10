using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MilenioRadartonaAPI.Relatorios
{
    public class DesastreRelatorio
    {

        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfDefault]
        public string _id { get; set; }


        [BsonElement("Rua")]
        public string Rua { get; set; }

        [BsonElement("TipoRua")]
        public string TipoRua { get; set; }


        [BsonElement("Tipo")]
        public string Tipo { get; set; }

        [BsonElement("GrauConfianca")]
        public string GrauConfianca { get; set; }

        [BsonElement("DataOcorrencia")]
        public DateTime DataOcorrencia { get; set; }



    }
}

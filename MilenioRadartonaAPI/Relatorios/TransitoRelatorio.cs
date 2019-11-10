using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilenioRadartonaAPI.Relatorios
{

    [BsonDiscriminator("TransitoRelatorio")]
    public class TransitoRelatorio
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfDefault]
        public string _id { get; set; }


        [BsonElement("Rua")]
        public string Rua { get; set; }

        [BsonElement("TipoRua")]
        public string TipoRua { get; set; }

        [BsonElement("Intencidade")]
        public string Intencidade { get; set; }

        [BsonElement("GrauConfianca")]
        public string GrauConfianca { get; set; }

        [BsonElement("DataOcorrencia")]
        public DateTime DataOcorrencia { get; set; }



    }
}

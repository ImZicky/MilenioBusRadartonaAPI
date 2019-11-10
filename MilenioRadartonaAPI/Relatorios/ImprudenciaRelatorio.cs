using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilenioRadartonaAPI.Relatorios
{

    [BsonDiscriminator("ImprudenciaRelatorio")]
    public class ImprudenciaRelatorio
    {

        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfDefault]
        public string _id { get; set; }

        [BsonElement("Rua")]
        public string Rua { get; set; }

        [BsonElement("Enquadramento")]
        public string Enquadramento { get; set; }

        [BsonElement("DataOcorrencia")]
        public DateTime DataOcorrencia { get; set; }


    }
}

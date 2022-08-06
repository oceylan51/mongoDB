using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [BsonIgnoreExtraElements]
    public class KeyResultProgresses
    {
        [BsonElement("status")]
        public string Status { get; set; }
        [BsonElement("obstacles")]
        public string Obstacles { get; set; }
        [BsonElement("notes")]
        public string Notes { get; set; }
        [BsonElement("thingstoimprove")]
        public string ThingsToImprove { get; set; }
    }
}
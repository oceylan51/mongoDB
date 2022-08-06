using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Entity
{
    [BsonIgnoreExtraElements]
    public class KeyResults
    {
        [BsonElement("title")]
        public string Title { get; set; }
        [BsonElement("description")]
        public string Description { get; set; }
        [BsonElement("startdatetime")]
        public string StratDateTime { get; set; }
        [BsonElement("enddatetime")]
        public string EndDateTime { get; set; }
        [BsonElement("existing")]
        public int Existing { get; set; }
        [BsonElement("current")]
        public int Current { get; set; }
        [BsonElement("target")]
        public int Target { get; set; }
        [BsonElement("progressratio")]
        public int ProgressRatio { get; set; }
        [BsonElement("keyresultwatchers")]
        public string[] KeyResultWatchers { get; set; }
        [BsonElement("keyresultactions")]
        public string[] KeyResultActions { get; set; }
        [BsonElement("keyresultprogresses")]
        public IEnumerable<KeyResultProgresses> KeyResultProgresses { get; set; }
        [BsonElement("okrconnections")]
        public string OkrConnections { get; set; }
    }
}
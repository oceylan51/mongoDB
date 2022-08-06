using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Entity
{
    [BsonIgnoreExtraElements]
    public class Users
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("createduserid")]
        [BsonRepresentation(BsonType.String)]
        public string CreatedUserId { get; set; }
        [BsonElement("createdusername")]
        public string CreatedUserName { get; set; }
        [BsonElement("title")]
        public string Title { get; set; }
        [BsonElement("description")]
        public string Description { get; set; }
        [BsonElement("startdatetime")]
        public string StratDateTime { get; set; }
        [BsonElement("enddatetime")]
        public string EndDateTime { get; set; }
        [BsonElement("objectivetype")]
        public int ObjectiveType { get; set; }
        [BsonElement("isvisible")]
        public bool IsVisible { get; set; }
        [BsonElement("objectiveassign")]
        public ObjectiveAssign ObjectiveAssign { get; set; }
        [BsonElement("objectivewatchers")]
        public List<ObjectiveWatchers> ObjectiveWatchers { get; set; }
        [BsonElement("keyresults")]
        public IEnumerable<KeyResults> KeyResults { get; set; }
        [BsonElement("okrconnections")]
        public string OkrConnections { get; set; }
        [BsonElement("ownercompanyid")]
        public string OwnerCompanyId { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Entity
{
    [BsonIgnoreExtraElements]
    public class ObjectiveAssign
    {
        [BsonElement("assigneduserid")]
        public string AssignedUserId { get; set; }
        [BsonElement("initial")]
        public string Initial { get; set; }
        [BsonElement("displayname")]
        public string DisplayName { get; set; }
        [BsonElement("isuserexist")]
        public bool IsUserExist { get; set; }
    }
}
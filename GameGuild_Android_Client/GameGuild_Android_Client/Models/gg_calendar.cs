using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CityTower_Android_Client.Models
{
    public class gg_calendar
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId _id { get; set; }
        public string name { get; set; }
        public BsonDateTime releaseDate { get; set; }
    }
}
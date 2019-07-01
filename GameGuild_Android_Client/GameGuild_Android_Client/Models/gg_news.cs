using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace CityTower_Android_Client.Models
{
    public class gg_news
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string name { get; set; }
        public string text { get; set; }
        public string[] genre { get; set; }
        public string[] tags { get; set; }
        public string[] category { get; set; }
        public file file { get; set; }
        public mark mark { get; set; }
        public int date_time_utc { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string userID { get; set; }
    }

    public class file
    {
        public string miniature { get; set; }
        public video[] video { get; set; }
        public photo[] photo { get; set; }
        public gif[] gif { get; set; }
    }

    public class video
    {
        public string link { get; set; }
        public string name { get; set; }
    }
    public class photo
    {
        public string link { get; set; }
        public string name { get; set; }
    }
    public class gif
    {
        public string link { get; set; }
        public string name { get; set; }
    }
    [ProtoContract]
    public class mark
    {
        [ProtoMember(1, IsRequired = true)]
        public int like { get; set; }
        [ProtoMember(2, IsRequired = true)]
        public int dislike { get; set; }
    }

    [ProtoContract]
    public class gg_news_mini
    {
        [ProtoMember(1, IsRequired = true)]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        [ProtoMember(2, IsRequired = true)]
        [BsonRepresentation(BsonType.ObjectId)]
        public string userID { get; set; }
        [ProtoMember(3, IsRequired = true)]
        public string name { get; set; }
        [ProtoMember(4, IsRequired = true)]
        public mark mark { get; set; }
        [ProtoMember(5, IsRequired = true)]
        public int date_time_utc { get; set; }
        [ProtoMember(6, IsRequired = true)]
        public string miniature { get; set; }
    }
}

using MongoDB.Bson;

namespace CityTower_Android_Client.Models
{
    public class gg_users
    {
        public ObjectId _id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string middlename { get; set; }
        public string nickname { get; set; }
        public BsonDateTime dateofregistration { get; set; }
        public BsonDateTime dateofbirthday { get; set; }
        public string avatar { get; set; }
        public BsonSymbol sex { get; set; }
        public achievements[] achievements { get; set; }
        public themes[] themes { get; set; }
    }
    public class achievements
    {
        public string name { get; set; }
        public string text { get; set; }
    }
    public class themes
    {
        public string name { get; set; }
        public string style { get; set; }
    }
}

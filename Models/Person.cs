using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PersonsApi.Models
{
    public class Person
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public int CompanyId { get; set; }
        public string PassportType { get; set; }
        public string PassportNumber { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using FluentAssertions;

namespace MongoDBApplicaiton
{

    public class TestMongoDB
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;

        public  static void TestData()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("test");

            var document = new BsonDocument
            {
                {
                    "address", new BsonDocument
                    {
                        {"street", "2 Avenue"},
                        {"zipcode", "10075"},
                        {"building", "1480"},
                        {"coord", new BsonArray {73.9557413, 40.7720266}}
                    }
                },
                {"borough", "Manhattan"},
                {"cuisine", "Italian"},
                {
                    "grades", new BsonArray
                    {
                        new BsonDocument
                        {
                            {"date", new DateTime(2014, 10, 1, 0, 0, 0, DateTimeKind.Utc)},
                            {"grade", "A"},
                            {"score", 11}
                        },
                        new BsonDocument
                        {
                            {"date", new DateTime(2014, 1, 6, 0, 0, 0, DateTimeKind.Utc)},
                            {"grade", "B"},
                            {"score", 17}
                        }
                    }
                },
                {"name", "Vella"},
                {"restaurant_id", "41704620"}
            };

            var collection = _database.GetCollection<BsonDocument>("restaurants");
            collection.InsertOneAsync(document);

            var filter = new BsonDocument();
            var count = 0;
            string value = "Empty";
            using (var cursor = collection.FindAsync(filter).Result)
            {
                while (cursor.MoveNextAsync().Result)
                {
                    var batch = cursor.Current;
                    foreach (var fetcheddocument in batch)
                    {
                        // process document
                        count.Should().Be(25359);

                        count++;
                    }
                }
            }
        }
    }

    public class TestAttributeData
    {
       [Required]
        public DateTime? date { get; set; }
    }
    public class Program
    {
       
        public static void Main(string[] args)
        {

            TestAttributeData testAttribute=new TestAttributeData();
           // testAttribute.date=DateTime.UtcNow;
            var vc=new ValidationContext(testAttribute,null,null);
            List<System.ComponentModel.DataAnnotations.ValidationResult> result=new List<ValidationResult>();
            var isvalid = Validator.TryValidateObject(testAttribute, vc, result,true);

            TestMongoDB.TestData();
        }
    }
}

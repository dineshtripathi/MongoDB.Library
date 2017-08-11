using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Infinity.WithNoSql.Repository.API.Library
{
    public class TestMongoDb
    {
        protected static IMongoClient Client;
        protected static IMongoDatabase Database;

        public static void TestData()
        {
            Client = new MongoClient();
            Database = Client.GetDatabase("test");

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

            var collection = Database.GetCollection<BsonDocument>("restaurants");
            collection.InsertOneAsync(document);

            var filter = new BsonDocument();
            using (var cursor = IMongoCollectionExtensions.FindAsync<BsonDocument>(collection, filter).Result)
            {
                while (cursor.MoveNextAsync().Result)
                {
                    var batch = cursor.Current;
                    foreach (var unused in batch)
                    {
                        // process document
                        unused.AllowDuplicateNames = true;
                        {
                            var i = unused.ElementCount;
                        }
                        //   count.Should().Be(25359);

                        Count++;
                    }
                }
            }
        }

        public static long Count { get; set; }
    }
}
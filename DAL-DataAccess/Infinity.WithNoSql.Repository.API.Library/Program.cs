using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infinity.WithNoSql.Repository.API.Library
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TestAttributeData testAttribute = new TestAttributeData();
            // testAttribute.date=DateTime.UtcNow;
            var vc = new ValidationContext(testAttribute, null, null);
            List<ValidationResult> result = new List<ValidationResult>();
            var unused = Validator.TryValidateObject(testAttribute, vc, result, true);

            TestMongoDb.TestData();
        }
    }
}
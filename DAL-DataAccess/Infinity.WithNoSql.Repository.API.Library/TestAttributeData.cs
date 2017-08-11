using System;
using System.ComponentModel.DataAnnotations;

namespace Infinity.WithNoSql.Repository.API.Library
{
    public class TestAttributeData
    {
        [Required]
        public DateTime? Date { get; set; }
    }
}
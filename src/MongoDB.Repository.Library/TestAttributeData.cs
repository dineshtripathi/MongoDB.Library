using System;
using System.ComponentModel.DataAnnotations;

namespace MongoDB.Repository.Library
{
    public class TestAttributeData
    {
        [Required]
        public DateTime? Date { get; set; }
    }
}
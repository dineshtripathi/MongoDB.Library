using System;
using System.ComponentModel.DataAnnotations;

namespace MongoDB.Repository.API.Library
{
    public class TestAttributeData
    {
        [Required]
        public DateTime? Date { get; set; }
    }
}
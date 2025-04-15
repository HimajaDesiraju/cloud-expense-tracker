using System;
using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class Category
    {
        [Key]
        public required string CategoryId { get; set; }
        public required string CategoryName { get; set; }
    }
}
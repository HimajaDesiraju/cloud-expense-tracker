using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Models
{
    public class Expense
    {
        [Key]
        public required string ExpenseId { get; set; }
        public decimal Amount { get; set; }
        public required string Description { get; set; }
        public DateTime Date { get; set; }
        public required string Status { get; set; }
        [ForeignKey("Category")]
        public required string CategoryId { get; set; }
        [ForeignKey("User")]
        public required string UserId { get; set; }
    }
}
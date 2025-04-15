using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace Models
{
    public class ApprovalHistory
    {
        [Key]
        public required string ApprovalHistoryId { get; set; }
        [ForeignKey("Expense")]
        public required string ExpenseId { get; set; }
        [ForeignKey("User")]
        public required string ManagerId { get; set; }
        public required string ActionTaken { get; set; }
        public DateTime ActionDate { get; set; }
        public required string Comments { get; set; }
    }
}

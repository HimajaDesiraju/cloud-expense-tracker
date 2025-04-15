using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Models
{
    public class NotificationLog
    {
        [Key]
        public required string NotificationId { get; set; }
        [ForeignKey("User")]
        public required string UserId { get; set; }
        public required string Message { get; set; }
        public required string Email { get; set; }
        public DateTime SentDateTime { get; set; }
        public required string Status { get; set; }
    }
}
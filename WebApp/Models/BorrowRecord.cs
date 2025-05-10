using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    [Table("borrowrecords")]
    public class BorrowRecord
    {
        [Key]
        [Column("borrow_id")]
        public int BorrowId { get; set; }

        [Column("device_id")]
        public int? DeviceId { get; set; }

        [Column("user_id")]
        public int? UserId { get; set; }

        [Column("borrow_date")]
        public DateTime? BorrowDate { get; set; }

        [Column("return_date")]
        public DateTime? ReturnDate { get; set; }

        [Column("actual_return_date")]
        public DateTime? ActualReturnDate { get; set; }

        // Navigation properties
        [ForeignKey("DeviceId")]
        public virtual Device Device { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
} 
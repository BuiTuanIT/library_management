using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WebApp.Models
{
    [Table("violations")]
    public class Violation
    {
        [Key]
        [Column("violations_id")]
        public int ViolationsId { get; set; }

        [Column("user_id")]
        public int? UserId { get; set; }

        [Column("device_id")]
        public int? DeviceId { get; set; }

        [Column("borrow_id")]
        public int? BorrowId { get; set; }

        [Column("reservations_id")]
        public int? ReservationsId { get; set; }

        [Column("violation_type")]
        public string? ViolationTypeString { get; set; }

        [NotMapped]
        public ViolationType? ViolationType
        {
            get
            {
                if (string.IsNullOrEmpty(ViolationTypeString)) return null;
                return ViolationTypeString switch
                {
                    "late_return" => Models.ViolationType.LateReturn,
                    "damaged" => Models.ViolationType.Damaged,
                    "lost" => Models.ViolationType.Lost,
                    "no_show" => Models.ViolationType.NoShow,
                    _ => null
                };
            }
            set => ViolationTypeString = value?.ToString().ToLower().Replace("_", "");
        }

        [Column("description")]
        public string? Description { get; set; }

        [Column("date_reported")]
        public DateTime DateReported { get; set; } = DateTime.Now;

        [Column("fine_amount")]
        [DataType(DataType.Currency)]
        public decimal? FineAmount { get; set; }

        [Column("status")]
        public string StatusString { get; set; } = "pending";

        [NotMapped]
        public ViolationStatus Status
        {
            get => StatusString switch
            {
                "pending" => Models.ViolationStatus.Pending,
                "resolved" => Models.ViolationStatus.Resolved,
                _ => Models.ViolationStatus.Pending
            };
            set => StatusString = value.ToString().ToLower();
        }

        // Navigation property
        [ForeignKey("DeviceId")]
        public virtual Device? Device { get; set; }
    }

    public enum ViolationType
    {
        [EnumMember(Value = "late_return")]
        LateReturn,

        [EnumMember(Value = "damaged")]
        Damaged,

        [EnumMember(Value = "lost")]
        Lost,

        [EnumMember(Value = "no_show")]
        NoShow
    }

    public enum ViolationStatus
    {
        [EnumMember(Value = "pending")]
        Pending,

        [EnumMember(Value = "resolved")]
        Resolved
    }
}


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class StudyAreaAccessLogs
    {
        [Key]
        [Column("log_id")]
        public int LogId { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("access_time")]
        public DateTime AccessTime { get; set; }

        // Navigation property để liên kết với User
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
} 
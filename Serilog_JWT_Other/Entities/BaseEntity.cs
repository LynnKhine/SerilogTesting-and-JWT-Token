using System.ComponentModel.DataAnnotations.Schema;

namespace Serilog_JWT_Other.Entities
{
    public class BaseEntity
    {
        [Column("CreatedUserId")]
        public string CreatedUserId { get; set; }

        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [Column("UpdatedUserId")]
        public string? UpdatedUserId { get; set; }

        [Column("UpdatedDate")]
        public DateTime? UpdatedDate { get; set; }
    }
}



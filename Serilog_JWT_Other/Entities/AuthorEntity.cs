using System.ComponentModel.DataAnnotations.Schema;

namespace Serilog_JWT_Other.Entities;

[Table("Authors")]
public class AuthorEntity : BaseEntity
{
    [Column("Id")]
    public string Id { get; set; }

    [Column("Name")]
    public string Name { get; set; }

    [Column("RealName")]
    public string RealName { get; set; }

    [Column("Bio")]
    public string Bio { get; set; }

}
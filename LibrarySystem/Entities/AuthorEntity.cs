using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Entities;

[Table("Authors")]
public class AuthorEntity
{
    [Column("Id")]
    public string Id { get; set; }

    [Column("Name")]
    public string Name { get; set; }

    [Column("RealName")]
    public string RealName { get; set; }

    [Column("Bio")]
    public string Bio { get; set; }

    [Column("CreatedUserId")]
    public string CreatedUserId { get; set; }

    [Column("CreatedDate")]
    public DateTime CreatedDate { get; set; }

    [Column("UpdatedUserId")]
    public string? UpdatedUserId { get; set; }

    [Column("UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }



}


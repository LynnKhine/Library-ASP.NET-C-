using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Entities;

[Table("Roles")]
public class RoleEntity : BaseEntity
{
    [Column("Id")]
    public string Id { get; set; }

    [Column("Name")]
    public string Name { get; set; }

    [Column("Description")]
    public string Description { get; set; }

}


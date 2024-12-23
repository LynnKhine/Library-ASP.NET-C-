using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Entities;

[Table("Staff")]
public class StaffEntity : BaseEntity
{
    [Column("Id")]
    public string Id { get; set; }

    [Column("Name")]
    public string Name { get; set; }

    [Column("RoleId")]
    public string RoleId { get; set; }

    [Column("Email")]
    public string Email { get; set; }

    [Column("UserName")]
    public string UserName { get; set; }

    [Column("HashedPassword")]
    public string HashedPassword { get; set; }

}


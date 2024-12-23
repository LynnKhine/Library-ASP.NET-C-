using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Entities;

[Table("Customers")]
public class CustomerEntity : BaseEntity
{
    [Column("Id")]
    public string Id { get; set; }

    [Column("Name")]
    public string Name { get; set; }

    [Column("PhoneNumber")]
    public int PhoneNumber { get; set; }

    [Column("Email")]
    public string Email { get; set; }

    [Column("Address")]
    public string Address { get; set; }

    [Column("IsBorrowed")]
    public bool IsBorrowed { get; set; }

}


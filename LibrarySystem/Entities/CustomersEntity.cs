using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Entities;

[Table("Customers")]
public class CustomersEntity
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

    [Column("CreatedUserId")]
    public string CreatedUserId { get; set; }

    [Column("CreatedDate")]
    public DateTime CreatedDate { get; set; }

    [Column("UpdatedUserId")]
    public string? UpdatedUserId { get; set; }

    [Column("UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }
}


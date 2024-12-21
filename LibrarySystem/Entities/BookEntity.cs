using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Entities;

[Table("Books")]
public class BookEntity
{
    [Column("Id")]
    public string Id { get; set; }

    [Column("Name")]
    public string Name { get; set; }

    [Column("AuthorId")]
    public string AuthorId { get; set; }

    [Column("CategoryId")]
    public string CategoryId { get; set; }

    [Column("PublishedYear")]
    public int PublishedYear { get; set; }

    [Column("TotalQuantity")]
    public int TotalQuantity { get; set; }

    [Column("AvailableQuantity")]
    public int AvailableQuantity { get; set; }

    [Column("CreatedUserId")]
    public string CreatedUserId { get; set; }

    [Column("CreatedDate")]
    public DateTime CreatedDate { get; set; }

    [Column("UpdatedUserId")]
    public string? UpdatedUserId { get; set; }

    [Column("UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }



}


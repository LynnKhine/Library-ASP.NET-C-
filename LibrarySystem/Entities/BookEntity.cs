using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Entities;

[Table("Books")]
public class BookEntity : BaseEntity
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

}


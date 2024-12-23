using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Entities;

[Table("BorrowHistories")]
public class BorrowHistoryEntity : BaseEntity
{
    [Column("Id")]
    public string Id { get; set; }

    [Column("CustomerId")]
    public string CustomerId { get; set; }

    [Column("BookId")]
    public string BookId { get; set; }

    [Column("BorrowDate")]
    public DateTime BorrowDate { get; set; }

    [Column("DueDate")]
    public DateTime DueDate { get; set; }

    [Column("ReturnDate")]
    public DateTime ReturnDate { get; set; }

}


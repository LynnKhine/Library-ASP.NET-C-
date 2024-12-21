using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Entities;

[Table("BorrowHistories")]
public class BorrowHistoryEntity
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

    [Column("CreatedUserId")]
    public string CreatedUserId { get; set; }

    [Column("CreatedDate")]
    public DateTime CreatedDate { get; set; }

    [Column("UpdatedUserId")]
    public string? UpdatedUserId { get; set; }

    [Column("UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }



}


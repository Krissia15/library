using System.ComponentModel.DataAnnotations;


namespace library.Models;


// One Book object holds one row of lending.book.
public class Book
{
    public long BookId { get; set; }


    // 1. Rule: a title of at most 150 characters.
    [StringLength(150, ErrorMessage = "The title can be at most 150 characters.")]
    public string Title { get; set; } = "";


    public string? Category { get; set; }


    // 2. Rule: a price from 0.01 to 99,999.99, when one is given.
    [Range(0.01, 99999.99, ErrorMessage = "The price must be from 0.01 to 99,999.99.")]
    public decimal? Price { get; set; }
}
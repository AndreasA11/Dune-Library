using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuneLibrary.Models;

public class Passage
{
    public int Id { get; set; }

    [Required]
    public string? Passages { get; set; }

    [Required]
    [RegularExpression(@"^[a-zA-Z0-9\-\?\!\.\'\:\;\,\""\s\/]+$")]
    public string Book { get; set; } = string.Empty;

    [Required]
    [Range(0, 1000, ErrorMessage = "Chapter must be in range of 0 - 1000")]
    public int ChapterNum { get; set; }

    [RegularExpression(@"^[a-zA-Z0-9\-\?\!\.\'\:\;\,\""\s\/]+$")]
    public string Author { get; set; } = string.Empty;

    [RegularExpression(@"^[a-zA-Z0-9\-\?\!\.\'\:\;\,\""\s\/]+$")]
    public string Series { get; set; } = string.Empty;

    [RegularExpression(@"^[a-zA-Z0-9\-\?\!\.\'\:\;\,\""\s\/]+$")]
    public string Organization { get; set; } = string.Empty;

    [Required]
    [Range(0, 10000, ErrorMessage = "Word count must be in range of 0 - 10000")]
    public int? WordCount { get; set; }

    public float? AverageRating { get; set; }
    
}
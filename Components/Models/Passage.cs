using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuneLibrary.Models;

public class Passage
{
    public int Id { get; set; }

    public string? Passages { get; set; }

    public string? Book { get; set; }

    public int ChapterNum { get; set; }

    public string? Author { get; set; }

    public string? Series { get; set; }

    public string? Organization { get; set; }

    public int? WordCount { get; set; }

    public float? AverageRating { get; set; }
    
}
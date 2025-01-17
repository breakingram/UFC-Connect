using System.ComponentModel.DataAnnotations;

namespace UFC.WebApp.DTOs;

public class FighterHeightDto
{
    [Required]
    [Range(1, 9)]
    public int Feet { get; set; }

    [Required]
    [Range(1, 11)]
    public int Inches { get; set; }
}

using System.ComponentModel.DataAnnotations;

namespace Moment4Api.Models;

//modell för låtar
public class SongModel
{
    //props
    public int Id { get; set; }

    [Required]
    public string? Artist { get; set; }

    [Required]
    public string? Title { get; set; }

    public int Length { get; set; }

    public string? Category { get; set; }
}
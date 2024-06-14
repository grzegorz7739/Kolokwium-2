using System.ComponentModel.DataAnnotations;

namespace Kolokwium2.Models;

public class Titles
{
    [Key]
    public int Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    public ICollection<Character_titles> CharacterTitles { get; set; } = new HashSet<Character_titles>();
}
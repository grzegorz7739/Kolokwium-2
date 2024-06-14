using System.ComponentModel.DataAnnotations;

namespace Kolokwium2.Models;

public class Characters
{
    [Key]
    public int Id { get; set; }
    [MaxLength(100)] 
    public string FirstName { get; set; } = string.Empty;
    [MaxLength(100)] 
    public string LastName { get; set; } = string.Empty;
    public int CurrentWeight { get; set; }
    public int MaxWeight { get; set; }

    public ICollection<Character_titles> CharacterTitles { get; set; } = new HashSet<Character_titles>();
    public ICollection<Backpacks> Backpacks { get; set; } = new HashSet<Backpacks>();
}
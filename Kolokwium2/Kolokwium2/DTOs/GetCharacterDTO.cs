using Kolokwium2.Models;

namespace Kolokwium2.DTOs;

public class GetCharacterDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int CurrentWeight { get; set; }
    public int MaxWeight { get; set; }
    public ICollection<GetCharacterBackpacksDTO> Backpacks { get; set; } = null!;
}

public class GetCharacterBackpacksDTO
{
    public string ItemName;
    public int ItemWeight;
    public int Amount;
}
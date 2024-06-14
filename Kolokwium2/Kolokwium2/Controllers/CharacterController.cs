using Kolokwium2.DTOs;
using Kolokwium2.Models;
using Kolokwium2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterController : ControllerBase
{
    private readonly IDbService _dbService;

    public CharacterController(IDbService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet("{characterID}")]
    public async Task<IActionResult> GetCharacterData(int characterID)
    {
        if (!await _dbService.DoesCharacterExist(characterID))
        {
            return NotFound($"Character with given ID - {characterID} doesnt exist");
        }

        var character = await _dbService.GetCharacterData(characterID);

        return Ok(character.Select(e => new GetCharacterDTO()
        {
            FirstName = e.FirstName,
            LastName = e.LastName,
            CurrentWeight = e.CurrentWeight,
            MaxWeight = e.MaxWeight,
            Backpacks = e.Backpacks.Select(p => new GetCharacterBackpacksDTO()
            {
                Amount = p.Amount,
                ItemName = p.Item.Name,
                ItemWeight = p.Item.Weight
            }).ToList()
            
        }));

    }
}
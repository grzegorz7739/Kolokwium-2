using Kolokwium2.Data;
using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;

    public DbService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<bool> DoesCharacterExist(int characterID)
    {
        return await _context.Characters.AnyAsync(e => e.Id == characterID);
    }

    public async Task<ICollection<Characters>> GetCharacterData(int characterID)
    {
        return await _context.Characters
            .Include(e => e.Backpacks)
            .Where(e => e.Id == characterID)
            .ToListAsync();
        

    }
}
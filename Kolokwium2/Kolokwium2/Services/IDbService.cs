using Kolokwium2.Models;

namespace Kolokwium2.Services;

public interface IDbService
{
    Task<bool> DoesCharacterExist(int characterID);

    Task<ICollection<Characters>> GetCharacterData(int characterID);
}
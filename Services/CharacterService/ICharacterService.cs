using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService 
    {
        Task<List<Character>> GetAllCharacter();        
        Task<Character> GetCharacterByID(int id);
        Task<List<Character>> AddCharacter(Character newCharacter);
    }
}
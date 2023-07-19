using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>() {
            new Character(),
            new Character { Id = 1, Name = "Sam" }
        };

        public async Task<List<Character>> GetAllCharacter() {
            return characters;
        }
        public async Task<Character> GetCharacterByID(int id) {
            return characters.FirstOrDefault(c => c.Id == id)!;
        }
        public async Task<List<Character>> AddCharacter(Character newCharacter) {
            characters.Add(newCharacter);
            return characters;
        }
    }
}
using System.Text.Json.Serialization;

namespace dotnet_rpg.Models
{
    //serve per fare apparire i nomi azichè i numeri
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3,
    }
}
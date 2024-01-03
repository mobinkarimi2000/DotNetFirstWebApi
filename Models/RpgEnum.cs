using System.Text.Json.Serialization;

namespace DotNetFirstWebApi.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgEnum
    {
        Knight=1,
        Mage=2,
        Cleric=3,
    }
}
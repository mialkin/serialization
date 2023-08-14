using System.Text.Json;
using Serialization.Standard.Serializers.Interfaces;

namespace Serialization.Standard.Serializers;

public class DefaultJsonSerializer : IDefaultJsonSerializer
{
    public string Serialize(object input) => JsonSerializer.Serialize(input);
    public T? Deserialize<T>(string input) => JsonSerializer.Deserialize<T>(input);
}
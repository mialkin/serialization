using System.Text.Json;
using Serialization.SystemTextJson.Serializers.Interfaces;

namespace Serialization.SystemTextJson.Serializers;

public class DefaultJsonSerializer : IDefaultJsonSerializer
{
    public string Serialize(object input) => JsonSerializer.Serialize(input);
    public T? Deserialize<T>(string input) => JsonSerializer.Deserialize<T>(input);
}
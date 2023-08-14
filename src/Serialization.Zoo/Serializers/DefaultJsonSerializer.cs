using System.Text.Json;
using Serialization.Zoo.Serializers.Interfaces;

namespace Serialization.Zoo.Serializers;

public class DefaultJsonSerializer : IDefaultJsonSerializer
{
    public string Serialize(object input) => JsonSerializer.Serialize(input);
    public T? Deserialize<T>(string input) => JsonSerializer.Deserialize<T>(input);
}
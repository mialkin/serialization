using System.Text.Json;
using System.Text.Json.Serialization;
using Serialization.Zoo.Serializers.Interfaces;

namespace Serialization.Zoo.Serializers;

public class RedisJsonSerializer : IRedisJsonSerializer
{
    private readonly JsonSerializerOptions _options;

    public RedisJsonSerializer() =>
        _options = new JsonSerializerOptions
        {
            Converters = { new JsonStringEnumConverter() },
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
        };

    public string Serialize(object input) => JsonSerializer.Serialize(input, _options);
    public T? Deserialize<T>(string input) => JsonSerializer.Deserialize<T>(input, _options);
}
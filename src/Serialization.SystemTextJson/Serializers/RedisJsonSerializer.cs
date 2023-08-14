using System.Text.Json;
using System.Text.Json.Serialization;
using Serialization.SystemTextJson.Serializers.Interfaces;

namespace Serialization.SystemTextJson.Serializers;

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
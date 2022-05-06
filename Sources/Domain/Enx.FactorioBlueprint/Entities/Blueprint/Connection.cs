using System.Text.Json.Serialization;

namespace Enx.FactorioBlueprint.Entities.Blueprint;

public record Connection
{
    [JsonPropertyName("1")]
    public ConnectionPoint First { get; set; } = null!;
    [JsonPropertyName("2")]
    public ConnectionPoint Second { get; set; } = null!;
}

public record ConnectionPoint
{
    public ConnectionData[] Red { get; init; } = Array.Empty<ConnectionData>();
    public ConnectionData[] Green { get; init; } = Array.Empty<ConnectionData>();
}

public record ConnectionData
{
    [JsonPropertyName("entity_id")]
    public int EntityId { get; init; }
    [JsonPropertyName("circuit_id")]
    public int CircuitId { get; init; }
}

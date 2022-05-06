using System.Text.Json.Serialization;

namespace Enx.FactorioBlueprint.Entities.Blueprint;

public class WaitCondition
{
    public string Type { get; init; } = default!;
    [JsonPropertyName("compare_type")]
    public string CompareType { get; init; } = default!;
    public uint? Ticks { get; init; }
}

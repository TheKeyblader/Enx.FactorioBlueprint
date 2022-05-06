using System.Text.Json.Serialization;

namespace Enx.FactorioBlueprint.Entities.Blueprint;

public record Schedule
{
    public int? Bar { get; init; }
}

public record ScheduleRecord
{
    public string Station { get; init; } = default!;
    [JsonPropertyName("wait_conditions")]
    public WaitCondition[] WaitConditions { get; init; } = Array.Empty<WaitCondition>();
}

namespace Enx.FactorioBlueprint.Entities.Blueprint;

public record Schedule
{
    public int? Bar { get; init; }
}

public record ScheduleRecord
{
    public string Station { get; init; } = default!;
}

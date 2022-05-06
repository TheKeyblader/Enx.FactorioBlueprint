namespace Enx.FactorioBlueprint.Entities.Blueprint;

public record SignalId
{
    public string Name { get; init; } = default!;
    public string Type { get; init; } = default!;
}

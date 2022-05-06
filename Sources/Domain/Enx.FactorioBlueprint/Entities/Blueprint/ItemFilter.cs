namespace Enx.FactorioBlueprint.Entities.Blueprint;

public record ItemFilter
{
    public string Name { get; init; } = default!;
    public int Index { get; init; }
}

namespace Enx.FactorioBlueprint.Entities.Blueprint;

public record InfinityFilter
{
    public string Name { get; init; } = default!;
    public int Count { get; init; }
    public string Mode { get; init; } = default!;
    public int Index { get; init; }
}

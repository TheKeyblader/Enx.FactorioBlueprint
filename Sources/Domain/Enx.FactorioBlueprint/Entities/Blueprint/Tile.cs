namespace Enx.FactorioBlueprint.Entities.Blueprint;

public record Tile
{
    public string Name { get; init; } = default!;
    public FactorioPosition Position { get; init; } = default!;
}

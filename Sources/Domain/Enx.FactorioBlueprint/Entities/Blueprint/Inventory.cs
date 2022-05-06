namespace Enx.FactorioBlueprint.Entities.Blueprint;

public record Inventory
{
    public int? Bar { get; init; }
    public ItemFilter[] Filters { get; init; } = Array.Empty<ItemFilter>();
}

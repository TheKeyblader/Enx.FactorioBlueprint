using System.Text.Json.Serialization;

namespace Enx.FactorioBlueprint.Entities.Blueprint;

public record InfinitySettings
{
    [JsonPropertyName("remove_unfiltered_items")]
    public bool RemoveUnFilteredItems { get; init; }
    public InfinityFilter[] Filters { get; init; } = Array.Empty<InfinityFilter>();
}

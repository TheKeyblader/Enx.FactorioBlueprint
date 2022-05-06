using System.Text.Json.Serialization;

namespace Enx.FactorioBlueprint.Entities.Blueprint
{
    public record BlueprintBook
    {
        public string Item { get; init; } = default!;
        public string Label { get; init; } = default!;
        [JsonPropertyName("label_color")]
        public FactorioColor? LabelColor { get; init; }
        public FactorioBlueprint[] Blueprints { get; init; } = Array.Empty<FactorioBlueprint>();
        [JsonPropertyName("active_index")]
        public int ActiveIndex { get; init; }
        public long Version { get; init; }
    }
}

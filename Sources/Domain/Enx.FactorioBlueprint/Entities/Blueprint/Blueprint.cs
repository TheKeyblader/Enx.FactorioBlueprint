using System.Text.Json.Serialization;

namespace Enx.FactorioBlueprint.Entities.Blueprint
{
    public record FactorioBlueprint
    {
        public string Item { get; init; } = default!;
        public string Label { get; init; } = default!;
        [JsonPropertyName("label_color")]
        public FactorioColor? LabelColor { get; init; }
        public FactorioEntity[] Entities { get; init; } = Array.Empty<FactorioEntity>();
        public Tile[] Tiles { get; init; } = Array.Empty<Tile>();
        public Icon[] Icons { get; init; } = Array.Empty<Icon>();
        public Schedule[] Schedules { get; init; } = Array.Empty<Schedule>();
        public long Version { get; init; } = default!;
    }
}

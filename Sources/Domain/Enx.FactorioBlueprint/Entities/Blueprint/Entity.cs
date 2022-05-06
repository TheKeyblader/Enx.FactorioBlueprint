using System.Text.Json.Serialization;

namespace Enx.FactorioBlueprint.Entities.Blueprint;

public record FactorioEntity
{
    [JsonPropertyName("entity_number")]
    public int EntityNumber { get; init; }
    public string Name { get; init; } = default!;
    public FactorioPosition Position { get; init; } = default!;
    public uint? Direction { get; init; }
    public float? Orientation { get; init; }
    public Dictionary<int, Connection>? Connections { get; init; }
    public Dictionary<string, int>? Items { get; init; }
    public string? Recipe { get; init; }
    public int? Bar { get; init; }
    public Inventory? Inventory { get; init; }
    [JsonPropertyName("infinity_settings")]
    public InfinitySettings? InfinitySettings { get; init; }
    public string? Type { get; init; }
    [JsonPropertyName("input_priority")]
    public string? InputPriority { get; init; }
    [JsonPropertyName("output_priority")]
    public string? OutputPriority { get; init; }
    public string? Filter { get; init; }
    [JsonPropertyName("filter_mode")]
    public ItemFilter[] Filters { get; init; } = Array.Empty<ItemFilter>();
    public string? FilterMode { get; init; }
    [JsonPropertyName("override_stack_size")]
    public byte? OverrideStackSize { get; init; }
    [JsonPropertyName("drop_position")]
    public FactorioPosition? DropPosition { get; init; }
    [JsonPropertyName("pickup_position")]
    public FactorioPosition? PickupPosition { get; init; }
    [JsonPropertyName("request_filters")]
    public LogisticFilter? RequestFilters { get; init; }
    [JsonPropertyName("request_from_buffers")]
    public bool RequestFromBuffers { get; init; }
    public SpeakerParameter? Parameters { get; init; }
    [JsonPropertyName("alert_parameters")]
    public SpeakerAlertParameter? AlertParameters { get; init; }
    [JsonPropertyName("auto_launch")]
    public bool? AutoLaunch { get; init; }
    public byte Variation { get; init; }
    public FactorioColor? Color { get; init; }
    public string? Station { get; init; }
}

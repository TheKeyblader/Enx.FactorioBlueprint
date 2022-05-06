using System.Text.Json.Serialization;

namespace Enx.FactorioBlueprint.Entities.Blueprint;

public record SpeakerParameter
{
    [JsonPropertyName("playback_volume")]
    public float Volume { get; init; }
    [JsonPropertyName("playback_globally")]
    public bool Globally { get; init; }
    [JsonPropertyName("allow_polyphony")]
    public bool AllowPolyphony { get; init; }
}

public record SpeakerAlertParameter
{
    [JsonPropertyName("show_alert")]
    public bool ShowAlert { get; init; }
    [JsonPropertyName("show_on_map")]
    public bool ShowOnMap { get; init; }
    [JsonPropertyName("icon_signal_id")]
    public SignalId IconSignalId { get; init; } = default!;
    [JsonPropertyName("alert_message")]
    public string Message { get; init; } = default!;
}

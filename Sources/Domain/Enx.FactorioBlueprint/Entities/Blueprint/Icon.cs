namespace Enx.FactorioBlueprint.Entities.Blueprint
{
    public record Icon
    {
        public int Index { get; init; }
        public SignalId Signal { get; init; } = default!;
    }
}

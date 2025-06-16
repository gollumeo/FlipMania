using Rituals.Contracts;
using Rituals.Runeforge;

namespace FlipMania.Api;

public class Runeforge : DormantRuneforge
{
    protected override IEnumerable<IRune> Frostmourne()
    {
        // no additional rune to load
        yield break;
    }
}
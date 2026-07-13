using UnityEngine;

public static class AncestorRNG
{
    public const float CommonChance = 75f;
    public const float UncommonChance = 20f;
    public const float UltraRareChance = 4f;
    public const float LegendaryChance = 1f;

    public static AncestorRarity RollRarity()
    {
        float roll = Random.value * 100f;

        if (roll < CommonChance)
            return AncestorRarity.Common;

        roll -= CommonChance;

        if (roll < UncommonChance)
            return AncestorRarity.Uncommon;

        roll -= UncommonChance;

        if (roll < UltraRareChance)
            return AncestorRarity.UltraRare;

        return AncestorRarity.Legendary;
    }
}   
using UnityEngine;

public class RollQualityManager : MonoBehaviour
{
    public static float RollMultiplier()
    {
        float roll = Random.Range(0f,100f);

        if (roll <= 80)
            return 1f;

        if (roll <= 98)
            return 1.25f;

        if (roll <= 99.9f)
            return 1.5f;

        return 2f;
    }
}

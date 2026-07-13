using UnityEngine;

public static class AttributeGenerator
{
    public static void Generate(AttributeType attribute)
    {
        AttributeData data =
            AttributeDatabase.Instance.GetAttribute(attribute);

        if (data == null)
            return;

        AttributeRoll roll = new AttributeRoll();

        roll.attribute = attribute;

        roll.buff1 = data.buff1;
        roll.buff1Value =
            Random.Range(data.buff1Min, data.buff1Max);

        roll.buff2 = data.buff2;
        roll.buff2Value =
            Random.Range(data.buff2Min, data.buff2Max);

        roll.buff3 = data.buff3;
        roll.buff3Value =
            Random.Range(data.buff3Min, data.buff3Max);

        PlayerAncestry.Instance.rolledAttributes.Add(roll);
    }
}
    using UnityEditor;
using UnityEngine;

public class GenerateAttributes
{
    [MenuItem("Tools/Venture/Generate Attributes")]
    public static void Generate()
    {
        CreateAttribute(AttributeType.War,
            "Team Fighting",10,30,
            "Strength",5,15,
            "Critical Damage",5,10);

        CreateAttribute(AttributeType.Ocean,
            "Water Resistance",20,40,
            "Swimming Speed",10,20,
            "",0,0);

        CreateAttribute(AttributeType.Death,
            "Death Damage",15,30,
            "Fear Resistance",10,20,
            "",0,0);

        CreateAttribute(AttributeType.Nature,
            "Healing Effect",10,25,
            "Poison Resistance",15,30,
            "",0,0);

        CreateAttribute(AttributeType.Crafting,
            "Crafting Speed",15,30,
            "Material Efficiency",10,20,
            "",0,0);

        CreateAttribute(AttributeType.Leadership,
            "Companion Damage",15,35,
            "Companion Health",15,35,
            "Companion Defense",10,20);

        CreateAttribute(AttributeType.Wisdom,
            "XP Gain",15,30,
            "Mana Capacity",10,25,
            "",0,0);

        CreateAttribute(AttributeType.Lightning,
            "Attack Speed",15,30,
            "Movement Speed",10,20,
            "",0,0);

        CreateAttribute(AttributeType.Speed,
            "Movement Speed",15,30,
            "Dodge Chance",5,15,
            "",0,0);

        CreateAttribute(AttributeType.Charm,
            "Merchant Prices",10,25,
            "Persuasion",10,25,
            "",0,0);

        CreateAttribute(AttributeType.Endurance,
            "Health",15,30,
            "Stamina",15,30,
            "Defense",10,20);

        CreateAttribute(AttributeType.Cosmic,
            "Mana Capacity",20,40,
            "Light Damage",15,30,
            "Cooldown Reduction",10,20);

        CreateAttribute(AttributeType.Fire,
            "Fire Damage",15,30,
            "Fire Resistance",20,40,
            "",0,0);

        CreateAttribute(AttributeType.Time,
            "Cooldown Reduction",10,20,
            "Attack Speed",10,20,
            "Skill Damage",10,20);

        CreateAttribute(AttributeType.Melee,
            "Melee Damage",15,30,
            "Critical Chance",5,15,
            "",0,0);

        CreateAttribute(AttributeType.Range,
            "Ranged Damage",15,30,
            "Accuracy",10,20,
            "",0,0);

        CreateAttribute(AttributeType.Combat,
            "Damage",10,25,
            "Critical Chance",5,15,
            "Defense",10,20);

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();

        Debug.Log("All attributes generated!");
    }

    static void CreateAttribute(
        AttributeType type,

        string buff1,float min1,float max1,

        string buff2,float min2,float max2,

        string buff3,float min3,float max3)
    {
        AttributeData asset =
            ScriptableObject.CreateInstance<AttributeData>();

        asset.attribute = type;

        asset.buff1 = buff1;
        asset.buff1Min = min1;
        asset.buff1Max = max1;

        asset.buff2 = buff2;
        asset.buff2Min = min2;
        asset.buff2Max = max2;

        asset.buff3 = buff3;
        asset.buff3Min = min3;
        asset.buff3Max = max3;

        AssetDatabase.CreateAsset(
            asset,
            $"Assets/Data/Attributes/{type}.asset");
    }
}
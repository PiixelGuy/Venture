using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ancestor", menuName = "Venture/Ancestor")]
public class AncestorData : ScriptableObject
{
    public string ancestorName;

    public Mythology mythology;

    public AncestorRarity rarity;

    public List<AttributeType> attributes = new();
}
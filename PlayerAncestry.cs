using System.Collections.Generic;
using UnityEngine;

public class PlayerAncestry : MonoBehaviour
{
    public static PlayerAncestry Instance;

    public AncestorData selectedAncestor;

    public List<AttributeType> unlockedAttributes =
        new List<AttributeType>();

    public List<AttributeRoll> rolledAttributes =
        new List<AttributeRoll>();

    private void Awake()
    {
        Instance = this;
    }
}           
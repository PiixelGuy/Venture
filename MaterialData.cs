using UnityEngine;

public enum MaterialType
{
    Raw,
    Processed,
    Essence,
    Enhancement
}

[CreateAssetMenu(menuName = "Venture/Material")]
public class MaterialData : ScriptableObject
{
    public string materialName;
    public MaterialType type;
    public Sprite icon;
    public bool stackable = true;
}
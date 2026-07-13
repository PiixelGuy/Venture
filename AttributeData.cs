using UnityEngine;

[CreateAssetMenu(menuName = "Venture/Attribute")]
public class AttributeData : ScriptableObject
{
    public AttributeType attribute;

    public string buff1;
    public float buff1Min;
    public float buff1Max;

    public string buff2;
    public float buff2Min;
    public float buff2Max;

    public string buff3;
    public float buff3Min;
    public float buff3Max;
}
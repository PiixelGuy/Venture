using UnityEngine;

public class AttributeDatabase : MonoBehaviour
{
    public static AttributeDatabase Instance;

    public AttributeData[] attributes;


void Awake()
{
Debug.Log("Attributes loaded: " + attributes.Length);
    Instance = this;
}   



   
    public AttributeData GetAttribute(AttributeType type)
    {
        
        foreach (AttributeData attribute in attributes)
        {
            if (attribute.attribute == type)
                return attribute;
        }

        return null;
    }

}


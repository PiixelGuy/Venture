using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    public List<InventoryItem> materials = new();

    void Awake()
    {
        Instance = this;
    }

    public void AddMaterial(MaterialData mat, int amount)
    {
        InventoryItem item =
            materials.Find(x => x.material == mat);

        if (item != null)
            item.amount += amount;
        else
            materials.Add(new InventoryItem()
            {
                material = mat,
                amount = amount
            });
    }
}   
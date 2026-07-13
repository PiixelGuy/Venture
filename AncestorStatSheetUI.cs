using TMPro;
using UnityEngine;

public class AncestorStatSheetUI : MonoBehaviour
{
    [Header("Ancestor")]
    public TMP_Text ancestorNameText;
    public TMP_Text mythologyText;
    public TMP_Text rarityText;

    [Header("Base Stats")]
    public TMP_Text baseStatsText;
    private AttributeRowUI selectedRow;

    [Header("Attributes")]
    public Transform attributeContent;
    public AttributeRowUI attributeRowPrefab;

    [Header("Buffs")]
    public TMP_Text buffsText;

    public void Refresh()
    {
        PlayerAncestry player = PlayerAncestry.Instance;

        if (player == null || player.selectedAncestor == null)
            return;

        // Ancestor Info
        ancestorNameText.text = player.selectedAncestor.ancestorName;
        mythologyText.text = player.selectedAncestor.mythology.ToString();
        rarityText.text = player.selectedAncestor.rarity.ToString();

        // Temporary Base Stats
        baseStatsText.text =
            "Health      100\n" +
            "Mana         50\n" +
            "Stamina     100\n" +
            "Strength     10\n" +
            "Speed        10\n" +
            "Defense      10";

        PopulateAttributes(player);
    }

    void PopulateAttributes(PlayerAncestry player)
    {
        Debug.Log("attributeContent = " + attributeContent);
Debug.Log("attributeRowPrefab = " + attributeRowPrefab);
Debug.Log("rolledAttributes = " + player.rolledAttributes.Count);
        // Remove old rows
        foreach (Transform child in attributeContent)
        {
            Destroy(child.gameObject);
        }

        // Create one row for each rolled attribute
        for (int i = 0; i < player.rolledAttributes.Count; i++)
        {
            AttributeRoll roll = player.rolledAttributes[i];

            AttributeRowUI row =
                Instantiate(attributeRowPrefab, attributeContent);

            row.attributeName.text = roll.attribute.ToString();

            int index = i;

            row.button.onClick.AddListener(() =>
        {
        SelectRow(row, player.rolledAttributes[index]);
        });
        }

        // Automatically display the first attribute's buffs
        if (player.rolledAttributes.Count > 0)
{
    AttributeRowUI firstRow =
        attributeContent.GetChild(0).GetComponent<AttributeRowUI>();

    SelectRow(firstRow, player.rolledAttributes[0]);
}
else
{
    buffsText.text = "No attributes.";
}
    }   

    void ShowBuffs(AttributeRoll roll)
    {
        buffsText.text =
            $"{roll.buff1} +{roll.buff1Value:F0}%";

        if (!string.IsNullOrEmpty(roll.buff2))
        {
            buffsText.text +=
                $"\n{roll.buff2} +{roll.buff2Value:F0}%";
        }

        if (!string.IsNullOrEmpty(roll.buff3))
        {
            buffsText.text +=
                $"\n{roll.buff3} +{roll.buff3Value:F0}%";
        }
    }
    void SelectRow(AttributeRowUI row, AttributeRoll roll)
{
    if (selectedRow != null)
        selectedRow.SetSelected(false);

    selectedRow = row;
    selectedRow.SetSelected(true);

    ShowBuffs(roll);
}
}
using TMPro;
using UnityEngine;

public class PlayerStatsUI : MonoBehaviour
{
    [Header("Base Stats")]
    public TMP_Text healthText;
    public TMP_Text manaText;
    public TMP_Text staminaText;
    public TMP_Text strengthText;
    public TMP_Text speedText;
    public TMP_Text defenseText;

    [Header("Resistances")]
    public TMP_Text fireResistText;
    public TMP_Text waterResistText;
    public TMP_Text poisonResistText;
    public TMP_Text lightningResistText;

    [Header("Equipment")]
    public TMP_Text weaponText;
    public TMP_Text helmetText;
    public TMP_Text chestText;
    public TMP_Text legsText;
    public TMP_Text bootsText;

    [Header("Skills")]
    public TMP_Text primarySkillText;
    public TMP_Text secondarySkillText;
    public TMP_Text passiveSkillText;
    public TMP_Text ultimateSkillText;

    public void Refresh()
    {
        // Base stats
        healthText.text = "100";
        manaText.text = "50";
        staminaText.text = "100";
        strengthText.text = "10";
        speedText.text = "10";
        defenseText.text = "10";

        // Resistances
        fireResistText.text = "0%";
        waterResistText.text = "0%";
        poisonResistText.text = "0%";
        lightningResistText.text = "0%";

        // Equipment
        weaponText.text = "None";
        helmetText.text = "None";
        chestText.text = "None";
        legsText.text = "None";
        bootsText.text = "None";

        // Skills
        primarySkillText.text = "Locked";
        secondarySkillText.text = "Locked";
        passiveSkillText.text = "Locked";
        ultimateSkillText.text = "Locked";
    }
}
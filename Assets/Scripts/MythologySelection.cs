using UnityEngine;

public class MythologySelection : MonoBehaviour
{
    public GameObject mythologySelectionUI;
    public GameObject statSheetUI;

    public AncestorStatSheetUI statSheet;

    public void ChooseGreek()
    {
        Select(Mythology.Greek);
    }

    public void ChooseRoman()
    {
        Select(Mythology.Roman);
    }

    private void Select(Mythology mythology)
    {
        // Roll the ancestor
        AncestorData chosen = AncestorDatabase.Instance.RollAncestor(mythology);

        PlayerAncestry.Instance.selectedAncestor = chosen;

        // TODO: Generate rolled attributes here
        PlayerAncestry.Instance.rolledAttributes.Clear();

        mythologySelectionUI.SetActive(false);

        statSheetUI.SetActive(true);
        statSheet.Refresh();

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
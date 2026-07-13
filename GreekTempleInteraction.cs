
using TMPro;
using UnityEngine;


public class GreekTempleInteraction : MonoBehaviour
{
    [SerializeField] private GameObject statSheetPanel;
[SerializeField] private AncestorStatSheetUI statSheetUI;
    [SerializeField] private GameObject interactionPrompt;

    private bool playerInRange;
    private bool hasChosen = false;

    private void Start()
    {
        interactionPrompt.SetActive(false);
    }

   private void OnTriggerEnter(Collider other)
{
    if (hasChosen)
        return;

    if (!other.CompareTag("Player"))
        return;

    playerInRange = true;
    interactionPrompt.SetActive(true);
}

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        playerInRange = false;
        interactionPrompt.SetActive(false);
    }

    private void Update()
{
    if (playerInRange && Input.GetKeyDown(KeyCode.E))
    {
        interactionPrompt.SetActive(false);
        hasChosen = true;

        GetComponent<Collider>().enabled = false;

       PlayerAncestry.Instance.selectedAncestor =
    AncestorDatabase.Instance.RollAncestor(Mythology.Greek);

PlayerAncestry.Instance.unlockedAttributes.Clear();
PlayerAncestry.Instance.rolledAttributes.Clear();

foreach (AttributeType attribute in PlayerAncestry.Instance.selectedAncestor.attributes)
{
    PlayerAncestry.Instance.unlockedAttributes.Add(attribute);
    AttributeGenerator.Generate(attribute);
}

statSheetPanel.SetActive(true);
statSheetUI.Refresh();
    }
}
}   
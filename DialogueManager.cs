using System.Collections;
using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField] private float typingSpeed = 0.04f;

    private Coroutine typingCoroutine;

    public Coroutine ShowDialogue(string line)
    {
        if (typingCoroutine != null)
            StopCoroutine(typingCoroutine);

        typingCoroutine = StartCoroutine(TypeLine(line));
        return typingCoroutine;
    }

    public IEnumerator TypeLine(string line)
    {
        if (dialogueText == null)
        {
            Debug.LogError("DialogueManager: Dialogue Text is not assigned.");
            yield break;
        }

        dialogueText.text = "";

        foreach (char letter in line)
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

        typingCoroutine = null;
    }

    public void ClearDialogue()
    {
        if (dialogueText != null)
            dialogueText.text = "";
    }
}
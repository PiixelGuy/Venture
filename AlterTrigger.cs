using System.Collections;
using UnityEngine;

public class MythologyPlatformTrigger : MonoBehaviour
{
    [Header("References")]
    public DialogueManager dialogueManager;
    public CanvasGroup dialogueCanvas;

    public GameObject mythologySelectionUI;

    [Header("Player")]
public PlayerMovement playerMovement;

    [Header("Settings")]
    public float fadeDuration = 1f;

    private bool activated = false;

    private void Start()
    {
        mythologySelectionUI.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (activated) return;

        if (other.CompareTag("Player"))
        {
            activated = true;
            StartCoroutine(ShowChoice());
        }
    }

    IEnumerator ShowChoice()
    {
        // Stop movement
        playerMovement.enabled = false;

        // First dialogue
        dialogueCanvas.alpha = 1;

        yield return StartCoroutine(
            dialogueManager.TypeLine(
                "Before you stand two ancient paths."
            ));

        yield return new WaitForSeconds(1f);

        yield return StartCoroutine(
            FadeCanvas(dialogueCanvas, 1, 0, fadeDuration));

        // Second dialogue
        dialogueCanvas.alpha = 1;

        yield return StartCoroutine(
            dialogueManager.TypeLine(
                "Choose your mythology."
            ));

        yield return new WaitForSeconds(1f);

        yield return StartCoroutine(
            FadeCanvas(dialogueCanvas, 1, 0, fadeDuration));

        // Show UI
        mythologySelectionUI.SetActive(true);

        // Unlock mouse
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    IEnumerator FadeCanvas(CanvasGroup canvas,
        float startAlpha,
        float endAlpha,
        float duration)
    {
        float elapsed = 0;

        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;

            canvas.alpha =
                Mathf.Lerp(startAlpha,
                            endAlpha,
                            elapsed / duration);

            yield return null;
        }

        canvas.alpha = endAlpha;
    }
}
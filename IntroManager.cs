using System.Collections;
using TMPro;
using UnityEngine;

public class IntroManager : MonoBehaviour
{
    [Header("Objects")]
    public GameObject blackScreen;

    [Header("Text")]
    public TMP_Text chapterText;
    public TMP_Text dialogueText;
    public TMP_Text objectiveText;

    [Header("Canvas Groups")]
    public CanvasGroup chapterCanvas;
    public CanvasGroup dialogueCanvas;
    public CanvasGroup blackScreenCanvas;

    [Header("Managers")]
    public DialogueManager dialogueManager;

    [Header("Settings")]
    public float fadeDuration = 1f;

    IEnumerator Start()
    {
        // Start invisible
        chapterCanvas.alpha = 0;
        dialogueCanvas.alpha = 0;

        chapterText.text = "";
        dialogueText.text = "";
        objectiveText.text = "";

        // Black screen stays up
        yield return new WaitForSeconds(2f);

        //--------------------------
        // Chapter
        //--------------------------
        chapterText.text = "Chapter 1: Who Am I?";

        yield return StartCoroutine(
            FadeCanvas(chapterCanvas, 0, 1, fadeDuration));

        yield return new WaitForSeconds(2f);

        yield return StartCoroutine(
            FadeCanvas(chapterCanvas, 1, 0, fadeDuration));

        //--------------------------
        // First Dialogue
        //--------------------------
        dialogueCanvas.alpha = 1;

        yield return StartCoroutine(
            dialogueManager.TypeLine(
                "Ugh... what just happened?"
            ));

        yield return new WaitForSeconds(1f);



        //--------------------------
        // Second Dialogue
        //--------------------------
        dialogueCanvas.alpha = 1;

        yield return StartCoroutine(
            dialogueManager.TypeLine(
                "Where am I?"
            ));

        yield return new WaitForSeconds(1f);

        yield return StartCoroutine(
            FadeCanvas(dialogueCanvas, 1, 0, fadeDuration));

        //--------------------------
        // Fade Black Screen Away
        //--------------------------
        yield return StartCoroutine(
            FadeCanvas(blackScreenCanvas, 1, 0, 2f));

        blackScreen.SetActive(false);

        //--------------------------
        // Objective
        //--------------------------
        objectiveText.text =
            "Objective: Learn Your Identity";
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

            canvas.alpha = Mathf.Lerp(
                startAlpha,
                endAlpha,
                elapsed / duration);

            yield return null;
        }

        canvas.alpha = endAlpha;
    }
}
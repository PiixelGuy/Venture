using System.Collections;
using TMPro;
using UnityEngine;

public class TMPFade : MonoBehaviour
{
    public float fadeSpeed = 2f;

    private TMP_Text textComponent;

    private void Awake()
    {
        textComponent = GetComponent<TMP_Text>();
    }

    public IEnumerator FadeIn()
    {
        gameObject.SetActive(true);

        Color c = textComponent.color;
        c.a = 0f;
        textComponent.color = c;

        while (textComponent.color.a < 1f)
        {
            c = textComponent.color;
            c.a += Time.deltaTime * fadeSpeed;
            textComponent.color = c;

            yield return null;
        }

        c.a = 1f;
        textComponent.color = c;
    }

    public IEnumerator FadeOut()
    {
        Color c = textComponent.color;

        while (textComponent.color.a > 0f)
        {
            c = textComponent.color;
            c.a -= Time.deltaTime * fadeSpeed;
            textComponent.color = c;

            yield return null;
        }

        c.a = 0f;
        textComponent.color = c;

        gameObject.SetActive(false);
    }
}
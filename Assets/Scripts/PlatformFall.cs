using System.Collections;
using UnityEngine;

public class PlatformFall : MonoBehaviour
{
    public float delayBeforeFall = 1f;
    public float fallSpeed = 10f;

    private bool falling = false;

    public void StartFall()
    {
        if (!falling)
        {
            StartCoroutine(FallRoutine());
        }
    }

    IEnumerator FallRoutine()
    {
        falling = true;

        yield return new WaitForSeconds(delayBeforeFall);

        Rigidbody rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.isKinematic = false;
            rb.useGravity = true;
        }
    }
}
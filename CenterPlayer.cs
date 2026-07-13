using UnityEngine;

public class CenterPlayer : MonoBehaviour
{
    public Transform platformCenter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CharacterController controller =
                other.GetComponent<CharacterController>();

            if (controller != null)
                controller.enabled = false;

            other.transform.position = platformCenter.position;

            if (controller != null)
                controller.enabled = true;
        }
    }
}
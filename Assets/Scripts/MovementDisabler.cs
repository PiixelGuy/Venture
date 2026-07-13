using UnityEngine;

public class DisableMovementButton : MonoBehaviour
{
    public PlayerMovement playerMovement;

    public void DisableMovement()
    {
        playerMovement.canMove = false;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilSpill : MonoBehaviour
{
    public float slowDownFactor = 0.5f;  // Multiplier for slowdown effect
    private FirstPersonMovement playerMovement;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerMovement = other.GetComponent<FirstPersonMovement>();
            if (playerMovement != null)
            {
                // Apply the slowdown by modifying the player's speed directly
                playerMovement.speed *= slowDownFactor;
                playerMovement.runSpeed *= slowDownFactor;  //Slow down running speed as well
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (playerMovement != null)
            {
                // Restore the original speed
                playerMovement.speed /= slowDownFactor;
                playerMovement.runSpeed /= slowDownFactor;
            }
        }
    }
}

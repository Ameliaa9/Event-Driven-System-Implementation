using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchTrap : MonoBehaviour
{
    public int damageAmount = 10;

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Player"))
        {
            healthBar playerHealth = other.collider.GetComponent<healthBar>();

            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageAmount);
                Debug.Log("Player took damage from punch trap! Health left: " + playerHealth.health);
            }
        }
    }
}
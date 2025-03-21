using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bladeDamage : MonoBehaviour
{
    public int damageAmount = 5; // Damage per hit

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Player"))
        {
            healthBar playerHealth = other.collider.GetComponent<healthBar>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageAmount);
                Debug.Log("Player took damage! Health left: " + playerHealth.health);
            }
        }
    }
}

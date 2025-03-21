using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class healthBar : MonoBehaviour
{
    public Slider healthSlider;
    public float maxHealth = 100f;
    public float health;

    void Start()
    {
        health = maxHealth;
        healthSlider.value = health;
        healthSlider.maxValue = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        health = Mathf.Clamp(health, 0, maxHealth); // Ensure health doesn't go below 0
        healthSlider.value = health;

        if (health <= 0)
        {
            Debug.Log("Player is dead!");
            SceneManager.LoadScene("loseScreen"); // Load the lose scene 
        }
    }
}
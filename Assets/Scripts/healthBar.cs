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

    void Update()
    {
        if (healthSlider.value != health)
        {
            healthSlider.value = health;
        }
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        healthSlider.value = health; 

        if (health <= 0)
        {
            Debug.Log("Player is dead!");
            SceneManager.LoadScene("WinScene"); // load the win scene
        }
    }
}
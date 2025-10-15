using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    private float initialHealth = 100f;
    private float currentHealth;
    [SerializeField]
    private Slider healthBar;
    [SerializeField]
    private UnityEvent onDie;
    public float CurrentHealth => currentHealth;

    public void InitializeHealth(float health)
    {
        initialHealth = health;
        currentHealth = initialHealth;
        UpdateHealthBar();
    }
    private void UpdateHealthBar()
    {
        if (healthBar != null)
        {
            healthBar.value = currentHealth / initialHealth;
        }
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, initialHealth);
        UpdateHealthBar();
        if (currentHealth <= 0)
        {
            Die();
        }
    }
      public void Die()
    
    {
        onDie?.Invoke();
    }
}


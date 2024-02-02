using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public Image healthBar;
    public Enemy enemy;

    void Start()
    {
        if (enemy != null)
        {
            enemy.OnHealthChange += EnemyOnHealthChanged;
        }
    }

    private void EnemyOnHealthChanged(object sender, HealthEvent e)
    {
        Debug.Log("Health changed to " +  e.Health + " " + sender);

        if (healthBar != null)
        {
            healthBar.fillAmount = e.Health / enemy.MaxHealth;
        }
    }
}
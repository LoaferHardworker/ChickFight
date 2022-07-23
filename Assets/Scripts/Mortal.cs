using UnityEngine;

public class Mortal : MonoBehaviour
{
    public int health;
    public int maxHealth;

    public void Damage(int damage)
    {
        health -= damage;
        if (health <= 0)
            Die();
        
        Debug.Log(health);
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}

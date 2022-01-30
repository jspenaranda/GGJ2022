using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    int startHealth = 0;
    [SerializeField] int currHealth;
    [SerializeField] int maxHealth = 100;
    [SerializeField] HealthBar healthBarLeft;
    [SerializeField] HealthBar healthBarRight;
    [SerializeField] GameSession gameSession;


    private void Start()
    {
        currHealth = startHealth; 
    }

    public void TakeDamage(int damage)
    {
        currHealth += damage;
        if(currHealth > 0)
        {
            healthBarLeft.SetHealth(0);
            healthBarRight.SetHealth(currHealth);
        }
        else if(currHealth < 0)
        {
            healthBarRight.SetHealth(0);
            healthBarLeft.SetHealth(Mathf.Abs(currHealth));
        }
        else if(currHealth == 0)
        {
            healthBarRight.SetHealth(0);
            healthBarLeft.SetHealth(0);
        }
        Die();
    }

    void Die()
    {
        if (Mathf.Abs(currHealth) >= maxHealth) 
        {
            gameSession.Reset();  
        } 
    }
}

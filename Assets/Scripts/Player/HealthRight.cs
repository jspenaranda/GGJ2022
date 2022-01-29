using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HealthRight : MonoBehaviour
{
    int minHealth = 0;
    [SerializeField] int currHealth;
    [SerializeField] HealthBar healthBar;
    

    private void Start()
    {
        currHealth = minHealth;        
    }
    
    public void TakeDamage(int damage)
    {
        currHealth += damage;
        healthBar.SetHealth(currHealth);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    int maxHealth = 100;
    [SerializeField]int currHealth;

    private void Start()
    {
        currHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currHealth -= damage;
    }


}
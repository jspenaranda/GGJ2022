using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerLeft : MonoBehaviour
{
    [SerializeField] HealthLeft player;
    [SerializeField] int damage = 20;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.TakeDamage(damage);
    }
}

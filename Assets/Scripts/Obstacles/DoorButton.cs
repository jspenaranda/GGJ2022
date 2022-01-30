using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    public bool �ffnen = false;
    PlayerSFX player;

    private void Start()
    {
        player = FindObjectOfType<PlayerSFX>();
    }
    void Update()
    {
        if (�ffnen)
        {
            player.PlayDoor();
            Destroy(gameObject);            
        }

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        �ffnen = true;
    }
}

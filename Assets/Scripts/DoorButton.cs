using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    public bool �ffnen = false;

    void Update()
    {
        if (�ffnen)
        {
            Destroy(gameObject);
            
        }

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        �ffnen = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    public bool öffnen = false;

    void Update()
    {
        if (öffnen)
        {
            Destroy(gameObject);
            
        }

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        öffnen = true;
    }
}

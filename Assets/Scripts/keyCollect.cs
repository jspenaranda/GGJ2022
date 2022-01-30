using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyCollect : MonoBehaviour
{
    public GameObject keyPart;
    LastDoor door;
    // Start is called before the first frame update
    void Start()
    {
        door = FindObjectOfType<LastDoor>();
        keyPart.SetActive(false); //line 45
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == ("Player"))
        {
            door.Check();
            keyPart.SetActive(true);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

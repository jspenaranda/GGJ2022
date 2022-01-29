using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyCollect : MonoBehaviour
{
    public GameObject keyPart;
    // Start is called before the first frame update
    void Start()
    {
        keyPart.SetActive(false); //line 45
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == ("Player"))
        {
            keyPart.SetActive(true);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

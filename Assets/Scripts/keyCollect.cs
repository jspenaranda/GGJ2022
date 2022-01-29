using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyCollect : MonoBehaviour
{
    [SerializeField] GUIKey key;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == ("Player"))
        {
            
            other.GetComponent<keyCounter>().points++;
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

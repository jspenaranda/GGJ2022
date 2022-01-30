using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastDoor : MonoBehaviour
{
    public bool open = false;
    public bool checker1 = false;
    public bool checker2 = false;
    public bool checker3 = false;
    public bool checker4 = false;

    void Update()
    {
        if (open && checker1 == true && checker2 == true && checker3 == true && checker4 == true)
        {
            Destroy(gameObject);
        }

    }

    public void Check()
    {
        if (checker1 == false)
        {
            checker1 = true;
        }else

        if (checker1 == true && checker2 == false)
        {
            checker2 = true;
        }else

        if (checker1 == true && checker2 == true && checker3 == false)
        {
            checker3 = true;
        }else

        if (checker1 == true && checker2 == true && checker3 == true && checker4 == false)
        {
            checker4 = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        open = true;

    }
}

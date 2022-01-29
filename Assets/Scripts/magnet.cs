using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnet : MonoBehaviour
{

    public Transform target;
    public float t;
    public float speed;
    public bool checker = false;

    void Update()
    {
        if (checker == true)
        {
            MoveStart();
        }

    }

    void MoveStart()
    {
        Vector2 a = transform.position;
        Vector2 b = target.position;
        transform.position = Vector2.MoveTowards(a, b, speed);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "magnet")
        {
            checker = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "magnet")
        {
            checker = false;
        }
    }
}

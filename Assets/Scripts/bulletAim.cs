using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletAim : MonoBehaviour
{
    float moveSpeed = 7f;

    Rigidbody2D rb;

    magnet target;
    Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<magnet>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Terrain"))
        {
            DestroySelf();
        }
        if (other.gameObject.CompareTag("Player"))
        {
            DestroySelf();
        }
        if (other.gameObject.CompareTag("Platform"))
        {
            DestroySelf();
        }

    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}

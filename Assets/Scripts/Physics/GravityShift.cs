using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityShift : MonoBehaviour
{
    [SerializeField] Transform player;
    BoxCollider2D gravityTrigger;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.GetComponent<Rigidbody2D>().gravityScale *= -1;
        player.Rotate(0,0,180);
    }
}

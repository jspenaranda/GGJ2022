using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityShift : MonoBehaviour
{
    [SerializeField] Transform player;
    BoxCollider2D gravityTrigger;
    AudioSource myAudioSource;

    private void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.GetComponent<Rigidbody2D>().gravityScale *= -1;
            player.Rotate(0, 0, 180);
            myAudioSource.Play();
        }
    }
}

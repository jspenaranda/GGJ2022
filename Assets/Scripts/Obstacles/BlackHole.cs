using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    [SerializeField] GameSession gameSession;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameSession.Reset();
    }
}

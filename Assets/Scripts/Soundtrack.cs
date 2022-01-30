using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundtrack : MonoBehaviour
{
    private void Awake()
    {
        int numGameSessions = FindObjectsOfType<GameSession>().Length;
        if (numGameSessions > 1)
        { Destroy(gameObject); }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

    }
}

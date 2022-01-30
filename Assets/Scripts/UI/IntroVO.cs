using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroVO : MonoBehaviour
{
    public void Play()
    {
        GetComponent<AudioSource>().Play();
    }
}

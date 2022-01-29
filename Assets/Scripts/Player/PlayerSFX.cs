using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSFX : MonoBehaviour
{
    [SerializeField] AudioClip jumpSFX;
    [SerializeField] AudioClip walkSFX;
    AudioSource myAudioSource;    

    private void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    public void PlayJump()
    {
        DeactivateLoop();
        myAudioSource.clip = jumpSFX;
        myAudioSource.Play();
    }

    public void PlayWalk()
    {
        myAudioSource.clip = walkSFX;        
        myAudioSource.Play();
        
    }

    public void DeactivateLoop()
    {
        myAudioSource.loop = false;
        myAudioSource.Stop();        
    }
}

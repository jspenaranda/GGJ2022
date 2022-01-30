using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSFX : MonoBehaviour
{
    [SerializeField] AudioClip jumpSFX;
    [SerializeField] AudioClip walkSFX;
    [SerializeField] AudioClip pullSFX; 
    [SerializeField] AudioClip pushSFX;
    [SerializeField] AudioClip doorSFX;
    [SerializeField] AudioClip keySFX;
    AudioSource myAudioSource;    

    private void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    public void PlayJump()
    {
        myAudioSource.clip = jumpSFX;
        myAudioSource.Play();
    }

    public void PlayPull()
    {
        myAudioSource.clip = pullSFX;
        myAudioSource.Play();
    }

    public void PlayPush()
    {        
        myAudioSource.clip = pushSFX;
        myAudioSource.Play();
    }

    public void PlayDoor()
    {
        myAudioSource.clip = doorSFX;
        myAudioSource.Play();
    }
    public void PlayWalk()
    {
        myAudioSource.clip = walkSFX;        
        myAudioSource.Play();        
    }

    public void PlayKey()
    {
        myAudioSource.clip = keySFX;
        myAudioSource.Play();
    }

}

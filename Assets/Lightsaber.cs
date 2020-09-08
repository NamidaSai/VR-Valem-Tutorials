using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightsaber : MonoBehaviour
{
    public AudioClip beamAudio;

    private AudioSource audioSource;
    private Animator animator;

    private void Start() 
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    public void TriggerBeam()
    {
        bool isOn = animator.GetBool("LightSaberOn");
        if (!isOn)
        {
            audioSource.PlayOneShot(beamAudio);
        }
        else
        {
            audioSource.Stop();
        }

        animator.SetBool("LightSaberOn", !isOn);
    }
}

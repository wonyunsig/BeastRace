using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    public AudioSource audioSource;

    private void Start()
    {
        // Ensure there's an AudioSource component attached to the button
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    public void PlaySound()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
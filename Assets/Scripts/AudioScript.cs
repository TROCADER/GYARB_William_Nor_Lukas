using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioScript : MonoBehaviour
{
    private PlayerController playerControllerScript;
    private AudioSource audioSource;
    private float pitch = 1f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        audioSource.Play(0);

        audioSource.pitch = pitch;
    }

    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            pitch += 0.0075f * Time.deltaTime;

            audioSource.pitch = pitch;
        }

        if (playerControllerScript.gameOver == true)
        {
            audioSource.Pause();
        }
    }
}
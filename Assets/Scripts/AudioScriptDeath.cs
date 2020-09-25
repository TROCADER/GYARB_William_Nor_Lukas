using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioScriptDeath : MonoBehaviour
{
    private PlayerController playerControllerScript;
    private AudioSource audioSource;
    private bool useOnce = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == true && useOnce == false)
        {
            audioSource.Play(0);
            useOnce = true;
        }
    }
}

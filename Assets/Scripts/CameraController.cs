using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public int targetFrameRate = 60;
    public float counter = 2f;

    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = targetFrameRate;
    }

    // Update is called once per frame
    void Update()
    {
        //Vet ej varför, men bestämde mig för att sätta räknaren för acceleration på kameran (kunde lika väl placerat den på spelaren)
        counter += 0.0015f;
    }
}

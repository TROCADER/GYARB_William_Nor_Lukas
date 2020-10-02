using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Start is called before the first frame update
    private float leftBound = -7f;

    private PlayerController playerControllerScript;
    private CameraController cameraControllerScript;
    
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        cameraControllerScript = GameObject.Find("Camera").GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate((Vector3.left * 2) * Time.deltaTime  * cameraControllerScript.counter);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject scorpionPrefab;
    public GameObject vulturePrefab;
    private Vector3 spawnPosGround = new Vector3(7, -3, 0);
    private Vector3 spawnPosAir = new Vector3(7, -2.5f, 0);
    private PlayerController playerControllerScript;

    public int repeatRate;
    private int timeToSpawn;

    public Random generator = new Random();

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            //Spawning-försök händer varje 1.5 sekunder (90frames/60fps = 1.5)
            if (timeToSpawn == 75)
            {
                repeatRate = Random.Range(0, 4);
                if (repeatRate == 1)
                {
                    SpawnVulture();
                }

                else if (repeatRate == 2 | repeatRate == 3)
                {
                    SpawnScorpion();
                }
                timeToSpawn = 0;
            }
            timeToSpawn++;
        }
    }

    void SpawnScorpion()
    {
        Instantiate(scorpionPrefab, spawnPosGround, scorpionPrefab.transform.rotation);
    }

    void SpawnVulture()
    {
        Instantiate(vulturePrefab, spawnPosAir, vulturePrefab.transform.rotation);
    }
}
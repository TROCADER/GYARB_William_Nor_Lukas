using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject scorpionPrefab;
    public GameObject vulturePrefab;
    private Vector3 spawnPosGround = new Vector3(7, -3, 0);
    private Vector3 spawnPosAir = new Vector3(7, -2, 0);
    private PlayerController playerControllerScript;

    public float startDelay1 = 1f;
    public float startDelay2 = 1f;
    public float repeatRate;

    public Random generator = new Random();

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        repeatRate = Random.Range(0, 100);

        if (repeatRate == 1)
        {
            SpawnScorpion();
        }

        repeatRate = Random.Range(0, 100);

        if (repeatRate == 1)
        {
            SpawnVulture();
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

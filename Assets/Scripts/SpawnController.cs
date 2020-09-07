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
    public float repeatRate1 = 1f;
    public float repeatRate2 = 1f;

    void Start()
    {
        InvokeRepeating("SpawnScorpion", startDelay1, repeatRate1);
        InvokeRepeating("SpawnVulture", startDelay2, repeatRate2);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
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

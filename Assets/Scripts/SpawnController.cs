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
    private CollisionWithOtherEnemy collisionWithOtherEnemyScript;
    private PlayerController playerControllerScript;

    public int repeatRate;

    public Random generator = new Random();

    void Start()
    {
        collisionWithOtherEnemyScript = GameObject.Find("Scorpion").GetComponent<CollisionWithOtherEnemy>();
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (collisionWithOtherEnemyScript.withinRange == false && playerControllerScript.gameOver == false)
        {
            repeatRate = Random.Range(0, 500);

            if (repeatRate == 1)
            {
                SpawnVulture();
            }

            else if (repeatRate == 2 | repeatRate == 3)
            {
                SpawnScorpion();
            }
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

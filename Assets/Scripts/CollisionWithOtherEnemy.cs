﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithOtherEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public bool withinRange;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        withinRange = true;
        Debug.Log("within");
    }

    private void OnTriggerExit2D(Collider2D other) {
        withinRange = false;
        Debug.Log("outside");
    }
}

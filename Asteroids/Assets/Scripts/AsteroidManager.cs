﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if(collision.GetComponent<Trig>() == null && collision.GetComponentInParent<PlayerManager>() == null)
        {
            Destroy(collision.gameObject);
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_hit : MonoBehaviour
{

    Player_Life PL;

    public GameObject particles;

    // Start is called before the first frame update
    void Start()
    {
        PL = FindObjectOfType<Player_Life>();
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Castle")
        {
            Debug.Log("Castle hit");

            PL.RespuestaMal();

        }

        Instantiate(particles, transform.position, Quaternion.identity);

        Destroy(gameObject);

    } // ()
    
}

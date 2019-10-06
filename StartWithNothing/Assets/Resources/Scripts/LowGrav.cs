﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowGrav : MonoBehaviour
{
    private GameObject player;
    private PlayerController pc;
    private Rigidbody2D rb;

    void Start(){
        player = GameObject.Find("Player");
        rb = player.GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision){
        rb.gravityScale = .5f;
    }

    private void OnTriggerExit2D(Collider2D collision){
        rb.gravityScale = 2;
    }
}
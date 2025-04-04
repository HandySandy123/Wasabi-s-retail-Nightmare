using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeMachine : MonoBehaviour
{
    public bool inUse = false;
    SpriteRenderer spriteRenderer;
    Collider2D collider2D;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        collider2D = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision");
    }

}

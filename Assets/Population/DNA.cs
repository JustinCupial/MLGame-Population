﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Schema;
using UnityEngine;
using Color = UnityEngine.Color;

public class DNA : MonoBehaviour
{
    public float r;
    public float g;
    public float b;
    public float s;

    bool dead = false;

    public float timeToDie = 0;

    private SpriteRenderer sRenderer;
    private Collider2D sCollider;

    void OnMouseDown()
    {
        dead = true;
        timeToDie = PopulationManager.elapsed;
        //Debug.Log("Dead at: " + timeToDie);
        sRenderer.enabled = false;
        sCollider.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        sCollider = GetComponent<Collider2D>();
        sRenderer.color = new Color(r,g,b);
        this.transform.localScale = new Vector3(s,s,s);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

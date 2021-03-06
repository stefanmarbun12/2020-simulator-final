﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
/// <summary>
/// This makes an object move randomly in a set of directions, with some random time delay in between each decision
/// </summary>
public class RandoController : Character {

    internal Transform thisTransform;
    Animator anim;
    public int skin = 0;
    public int mask = 0;
    public bool right;
    public bool friend;
    public float friendRatio;
 
    // Use this for initialization
    void Awake() {   
        radius = 10;
        friend = false;
        friendRatio = 0;
        moveSpeed = 2.0f;
        anim = GetComponent<Animator>();
        skin = Random.Range(0,4);
        mask = Random.Range(0,10);
        anim.SetInteger("Skin",skin);
        anim.SetInteger("Mask",mask);
    }
 
    void Update() {
        right = this.transform.GetComponent<Wander>().right;
        base.radiusChange();
    }
}
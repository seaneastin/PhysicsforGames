﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class PhysicsObjectBehavior : MonoBehaviour
{
    public Material awakeMaterial = null;
    public Material sleepingMaterial = null;

    private Rigidbody _rigidbody = null;


    bool wasSleeping = false;


    // Start is called before the first frame update
    void Start()
    {
        
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if  (_rigidbody.IsSleeping() && !wasSleeping && sleepingMaterial != null)
        {
            wasSleeping = true;
            GetComponent<MeshRenderer>().material = sleepingMaterial;
        }    

        if(!_rigidbody.IsSleeping() && wasSleeping && awakeMaterial != null)
        {
            wasSleeping = false;
            GetComponent<MeshRenderer>().material = awakeMaterial;
        }
    }

}

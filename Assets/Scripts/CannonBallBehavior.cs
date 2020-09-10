using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class CannonBallBehavior : MonoBehaviour
{
    public float forceOnFire = 300;

    bool fire = false;
    bool canFire = true;

    Rigidbody rigidbody = null;

    // use this for initialization

    private void Start()
    {
        
    }

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.isKinematic = true;
    }

    private void Update()
    {
        if(Input.GetKeyDown("space") && canFire)
        {
            rigidbody.isKinematic = false;
            rigidbody.AddForce(transform.forward * forceOnFire);
            canFire = false;
        }
    }
}

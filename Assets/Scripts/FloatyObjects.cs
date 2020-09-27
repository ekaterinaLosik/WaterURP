using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatyObjects : MonoBehaviour {

    public float FloatStrength = 4;

    private Rigidbody rigidBody;

    private void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        rigidBody.velocity = new Vector3(0, FloatStrength, 0);
    
    }
}

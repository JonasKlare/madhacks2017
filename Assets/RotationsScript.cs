using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationsScript : MonoBehaviour {

    public Rigidbody2D rb;
    public float _speed = 1.0f;
    public float rotation;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rotation = rotation + _speed + Time.fixedDeltaTime;
        rb.MoveRotation(rotation);
        
    }
}

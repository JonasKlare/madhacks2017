using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neutrophil : MonoBehaviour {

    float x, y;
    public float speed = 1.0f;
    Vector3 curr;

    public Neutrophil()
    {
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }
}

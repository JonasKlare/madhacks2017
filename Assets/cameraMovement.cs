using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour {

    public float speed = 1f;
    public float bloodStreamSpeed = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        
        transform.position += Vector3.down * speed * Time.deltaTime;
    }
}

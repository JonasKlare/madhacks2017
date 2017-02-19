using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeutrophilSpawner : MonoBehaviour {

    public bool spawn = false;
    public Vector3 bar;
    float time = Time.realtimeSinceStartup;
	// Use this for initialization
	void Start () {
        Vector3 bar = transform.position;
	}

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        //Wait X amount of seconds then call spawn to true. 
        if (time >= 3)
        {
            Instantiate(new Neutrophil(bar), bar, Quaternion.identity);
            time = 0;
        }
    }
}

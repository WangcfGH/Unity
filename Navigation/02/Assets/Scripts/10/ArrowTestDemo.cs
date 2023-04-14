using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowTestDemo : MonoBehaviour {
    public GameObject prefabParticleSystem;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject go = GameObject.Instantiate(prefabParticleSystem, Vector3.zero, Quaternion.identity);
            go.GetComponent<ArrowManager>().PlayArrowParticle();
            GameObject.Destroy(go, 1);
        }
	}
}

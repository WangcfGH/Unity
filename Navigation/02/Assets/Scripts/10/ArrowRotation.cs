using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowRotation : MonoBehaviour {
    private Transform m_transform;
	// Use this for initialization
	void Start () {
        m_transform = gameObject.GetComponent<Transform>();
	}

    void Update()
    {
        m_transform.Rotate(new Vector3(360 * Time.deltaTime, 0, 0));
    }
}

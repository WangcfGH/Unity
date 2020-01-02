using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
	private Transform	m_Transform;
    // Start is called before the first frame update
    void Start()
    {
		m_Transform = gameObject.GetComponent<Transform>();
		gameObject.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }

    // Update is called once per frame
    void Update()
    {
		if (m_Transform.position.y < -15)
		{
			GameObject.Destroy(gameObject);
		}
    }
}

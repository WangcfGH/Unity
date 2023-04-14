using UnityEngine;
using System.Collections;

public class KinghtCamera : MonoBehaviour {
    private Transform m_transform;
    private Transform m_playerTransform;

	// Use this for initialization
	void Start () 
    {
        m_transform = gameObject.GetComponent<Transform>();
        m_playerTransform = GameObject.Find("RoyalKnight").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        Vector3 v = new Vector3(0, 2.21f, -2.53f) + m_playerTransform.position;
        m_transform.position = Vector3.Lerp(m_transform.position, v, Time.deltaTime * 8);
	}
}

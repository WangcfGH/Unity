using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFllow : MonoBehaviour 
{
    private Transform   m_TransformCamera;
    private Transform   m_TransformPlayer;
    private Vector3     m_OffSet;

	void Start () 
    {
        m_TransformCamera = gameObject.GetComponent<Transform>();
        m_TransformPlayer = GameObject.Find("Player").GetComponent<Transform>();
        m_OffSet = new Vector3(-1.933473f, 5.869598f, -8.214413f);
	}
	
	// Update is called once per frame
	void Update () 
    {
        m_TransformCamera.position = Vector3.Lerp(m_TransformCamera.position, m_TransformPlayer.position + m_OffSet, Time.deltaTime);
	}
}

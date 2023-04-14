using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1 : MonoBehaviour 
{
    public int          m_nSpeed;
    private Transform   m_Transform;
	
	void Start () 
    {
        m_Transform = gameObject.GetComponent<Transform>();
	}
	
	void Update () 
    {
        if (Input.GetKey(KeyCode.A))
        {
            m_Transform.Translate(Vector3.left * Time.deltaTime * m_nSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            m_Transform.Translate(Vector3.right * Time.deltaTime * m_nSpeed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            m_Transform.Translate(Vector3.forward * Time.deltaTime * m_nSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            m_Transform.Translate(Vector3.back * Time.deltaTime * m_nSpeed);
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.name + "OnCollisionEnter");
    }
}

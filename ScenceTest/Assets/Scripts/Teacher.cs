using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teacher : MonoBehaviour
{
    private
        Transform m_transform;
        Rigidbody m_rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        m_transform = gameObject.GetComponent<Transform>();
        m_rigidbody = gameObject.GetComponent<Rigidbody>();        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            m_rigidbody.MovePosition(m_transform.position + Vector3.forward * 0.1f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            m_rigidbody.MovePosition(m_transform.position + Vector3.back * 0.1f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            m_rigidbody.MovePosition(m_transform.position + Vector3.right * 0.1f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            m_rigidbody.MovePosition(m_transform.position + Vector3.left * 0.1f);
        }
    }

    // 固定帧数 避免卡顿
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            //m_rigidbody.AddRelativeForce(Vector3.left * 100, ForceMode.Force);
            m_rigidbody.AddForce(Vector3.left * 100, ForceMode.Force);
        }
    }

    /*
    void OnCollisionEnter(Collision coll)
    {
        Debug.Log("Collision Enter:" + coll.gameObject.name);
    }

    void OnCollisionExit(Collision coll)
    {
        Debug.Log("Collision Exit:" + coll.gameObject.name);
    }

    void OnCollisionStay(Collision coll)
    {
        Debug.Log("Collision Stay:" + coll.gameObject.name);
    }
    */

    void OnTriggerEnter(Collider coll)
    {
        Debug.Log("Trigger Enter:" + coll.gameObject.name);
    }

    void OnTriggerExit(Collider coll)
    {
        Debug.Log("Trigger Exit:" + coll.gameObject.name);
    }

    void OnTriggerStay(Collider coll)
    {
        Debug.Log("Trigger Stay:" + coll.gameObject.name);
    }
}

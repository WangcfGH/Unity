using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTest : MonoBehaviour
{
    private Transform m_transform;

    // Start is called before the first frame update
    void Start()
    {
        m_transform = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            m_transform.Translate(m_transform.forward * 0.1f, Space.Self);
        }

        if (Input.GetKey(KeyCode.S))
        {
            m_transform.Translate(m_transform.forward * -0.1f, Space.Self);
        }

        if (Input.GetKey(KeyCode.D))
        {
            m_transform.Translate(m_transform.right * 0.1f, Space.Self);
        }

        if (Input.GetKey(KeyCode.A))
        {
            m_transform.Translate(m_transform.right * -0.1f, Space.Self);
        }
    }
}

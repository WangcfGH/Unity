using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Transform m_Transform;

    private void Start()
    {
        m_Transform = gameObject.GetComponent<Transform>();    
    }

    // Update is called once per frame
    void Update()
    {
        m_Transform.Translate(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }
}

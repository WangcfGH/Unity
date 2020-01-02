using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    private TextMesh    m_TextMesh;
    private Transform   m_Transform;

    void Start()
    {
        m_Transform = gameObject.GetComponent<Transform>();
        m_TextMesh = GameObject.Find("Score").GetComponent<TextMesh>();
    }

    void Update()
    {
        m_Transform.Rotate(Vector3.forward, 10.0f);
    }

    public void AddScore()
    {
        int nScore = int.Parse(m_TextMesh.text);
        m_TextMesh.text = (nScore + 1).ToString();
    }
}

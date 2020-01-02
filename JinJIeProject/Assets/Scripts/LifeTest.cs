using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTest : MonoBehaviour
{
    public      GameObject m_PrefabCube;
    private     GameObject m_Cube;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            m_Cube = GameObject.Instantiate(m_PrefabCube, Vector3.zero, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            GameObject.Destroy(m_Cube);
        }
    }
}

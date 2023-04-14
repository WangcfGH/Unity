using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrimitive : MonoBehaviour
{
    public GameObject       m_CubePrefab;
    public GameObject       myCube;
    public int              transSpeed  = 100;
    public float            rotaSpeed   = 10.5f;
    public float            scale       = 3;

    private void OnGUI()
    {
        if (GUILayout.Button("CreateCube", GUILayout.Height(50)))
        {
            GameObject m_cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            m_cube.AddComponent<Rigidbody>();
            m_cube.GetComponent<Renderer>().material.color = Color.blue;
            m_cube.transform.position = new Vector3(0, 10, 0);
        }
        if (GUILayout.Button("CreateSphere", GUILayout.Height(50)))
        {
            GameObject m_cube = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            m_cube.AddComponent<Rigidbody>();
            m_cube.GetComponent<Renderer>().material.color = Color.red;
            m_cube.transform.position = new Vector3(0, 10, 0);
        }

        if (GUILayout.Button("移动立方体"))
        {
            myCube.transform.Translate(Vector3.forward * transSpeed * Time.deltaTime, Space.World);
        }
        if (GUILayout.Button("旋转立方体"))
        {
            myCube.transform.Rotate(Vector3.up * rotaSpeed, Space.World);
        }
        if (GUILayout.Button("缩放立方体"))
        {
            myCube.transform.localScale = new Vector3(scale, scale, scale);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(m_CubePrefab, new Vector3(0, 10, 0), Quaternion.identity);
        }
    }
}

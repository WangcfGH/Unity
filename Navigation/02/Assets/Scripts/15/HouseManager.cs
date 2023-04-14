using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseManager : MonoBehaviour 
{
    public static HouseManager Instance;

    private Transform   m_TransformWall_1;
    private Transform   m_TransformWall_2;
	
    void Awake()
    {
        Instance = this;
    }

	void Start () 
    {
        m_TransformWall_1 = GameObject.Find("Evn/Wall_1").GetComponent<Transform>();
        m_TransformWall_2 = GameObject.Find("Evn/Wall_2").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    StartCoroutine(OpenWall(m_TransformWall_1));
        //}

        //if (Input.GetKeyDown(KeyCode.B))
        //{
        //    StartCoroutine(OpenWall(m_TransformWall_2));
        //}	
	}

    public void OpenFirstWall()
    {
        StartCoroutine(OpenWall(m_TransformWall_1));
    }

    public void OpenSecondWall()
    {
        StartCoroutine(OpenWall(m_TransformWall_2));
    }

    IEnumerator OpenWall(Transform wall)
    {
        while (wall.position.y > -2.0f)
        {
            wall.position = new Vector3(wall.position.x, wall.position.y - 0.1f, wall.position.z);
            yield return new WaitForSeconds(0.05f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonstersManager : MonoBehaviour 
{
    public static MonstersManager Instance;
    private Transform           m_Transform;
    private Transform[]         m_PointsTransform;
    private List<GameObject>    m_ListMonster;
    private GameObject          m_MonsterAAA;
    private GameObject          m_MonsterBBB;

    void Awake()
    {
        Instance = this;
    }

	void Start () 
    {
        m_Transform = gameObject.GetComponent<Transform>();
        m_PointsTransform = m_Transform.GetComponentsInChildren<Transform>();
        m_MonsterAAA = Resources.Load<GameObject>("Goblin");
        m_MonsterBBB = Resources.Load<GameObject>("Goblin");
        m_ListMonster = new List<GameObject>();
        Debug.Log(m_MonsterAAA.name);
        Debug.Log(m_MonsterBBB.name);
	}
	
	void Update () 
    {
        //if (Input.GetKeyDown(KeyCode.C))
        //{
        //    CreateAllMonsters();
        //}	
	}

    public void CreateAllMonsters()
    {
        for (int i = 1; i < m_PointsTransform.Length; i++)
        {
            if (i % 2 == 0)
            {
                CreateMonster(m_MonsterAAA, m_PointsTransform[i].position, 2.0f);
            }
            else
            {
                CreateMonster(m_MonsterBBB, m_PointsTransform[i].position, 5.0f);
            }
        }
    }

    private void CreateMonster(GameObject prefabMonster, Vector3 pos, float distance)
    {
        GameObject tempPrefeb = GameObject.Instantiate<GameObject>(prefabMonster, pos, Quaternion.identity);
        tempPrefeb.GetComponent<Transform>().SetParent(gameObject.GetComponent<Transform>());
        tempPrefeb.AddComponent<Monster>();
        tempPrefeb.GetComponent<Monster>().SetTarget("Player", distance);
        m_ListMonster.Add(tempPrefeb);
    }

    public void DestroyMonster(GameObject monster)
    {
        m_ListMonster.Remove(monster);
        if (m_ListMonster.Count == 0)
        {
            HouseManager.Instance.OpenSecondWall();
        }
    }
}

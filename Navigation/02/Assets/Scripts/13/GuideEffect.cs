using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideEffect : MonoBehaviour 
{
    public GameObject   m_pfbLineRender;
    public GameObject   m_pfbGoadEffect;

    private GameObject  m_objLineRender;
    private GameObject  m_objGoadEffect;

    //private HouseManager m_HouseManager;

    private Transform   m_transform;
    private Vector3     m_point1;
    private Vector3     m_point2;
    private Vector3     m_point3;

	void Start () 
    {
        m_transform = gameObject.GetComponent<Transform>();
        m_point1 = m_transform.GetChild(0).position;
        m_point2 = m_transform.GetChild(1).position;
        m_point3 = m_transform.GetChild(2).position;
        Debug.Log(m_point1);
        Debug.Log(m_point2);
        Debug.Log(m_point3);

        //m_HouseManager = GameObject.Find("HouseManager").GetComponent<HouseManager>();
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    private void TriggerGuideEffect(object value)
    {
        if ((int)value == 1)
        {
            CreateGuideRouteEffect(m_point1, m_point2);
        }
        else if ((int)value == 2)
        {
            CreateGuideRouteEffect(m_point2, m_point3);
        }
        else if ((int)value == 3)
        {
            DestroyGuidRouteEffect();
            // 触发开门
            //m_HouseManager.OpenFirstWall();
            // 单例模式
            HouseManager.Instance.OpenFirstWall();
        }
    }

    private void CreateGuideRouteEffect(Vector3 startPoint, Vector3 endPoint)
    {
        DestroyGuidRouteEffect();
        m_objLineRender = GameObject.Instantiate(m_pfbLineRender, startPoint, Quaternion.identity);
        m_objLineRender.GetComponent<LineRenderer>().SetPosition(0, startPoint);
        m_objLineRender.GetComponent<LineRenderer>().SetPosition(1, endPoint);

        m_objGoadEffect = GameObject.Instantiate(m_pfbGoadEffect, endPoint, Quaternion.identity);
    }

    private void DestroyGuidRouteEffect()
    {
        if (m_objLineRender)
        {
            GameObject.Destroy(m_objLineRender);    
        }

        if (m_objGoadEffect)
        {
            GameObject.Destroy(m_objGoadEffect);   
        }
    }
}

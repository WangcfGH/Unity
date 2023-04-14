using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour {
    private Transform       m_Transform;
    private Text            m_MaxNumText;
    private Text            m_MinNumText;

	// Use this for initialization
	void Awake () {
        m_Transform = gameObject.GetComponent<Transform>();
        m_MaxNumText = m_Transform.Find("MaxNum").GetComponent<Text>();
        m_MinNumText = m_Transform.Find("MinNum").GetComponent<Text>();
	}
	
    public void SetValue(int nMaxNum, int nMinNum)
    {
        m_MaxNumText.text = nMaxNum.ToString();
        m_MinNumText.text = nMinNum.ToString();
    }
}

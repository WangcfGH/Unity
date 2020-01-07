using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTime : MonoBehaviour
{
	private UIManager		m_UiManager;
	private TextMesh		m_TextMesh;

	void Start()
	{
		// 获取UI脚本
		m_UiManager = GameObject.Find("UI").GetComponent<UIManager>();
		m_TextMesh = gameObject.GetComponent<TextMesh>();
	}

	void Update()
	{
		float fLastTime = m_UiManager.GetLastTime();
		m_TextMesh.text = "时间：" + fLastTime.ToString() + "秒";
	}
}

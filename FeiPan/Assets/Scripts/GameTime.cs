using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTime : MonoBehaviour
{
	private UIManager		m_UiManager;	// UI管理器
	private TextMesh		m_TextMesh;		// 时间组件

	void Start()
	{
		// 获取UI脚本
		m_UiManager = GameObject.Find("UI").GetComponent<UIManager>();
		// 获取时间组件
		m_TextMesh = gameObject.GetComponent<TextMesh>();
	}

	void Update()
	{
		// 更新时间
		float fLastTime = m_UiManager.GetLastTime();
		m_TextMesh.text = "时间：" + fLastTime.ToString() + "秒";
	}
}

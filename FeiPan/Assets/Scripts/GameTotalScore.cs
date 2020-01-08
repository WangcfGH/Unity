using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTotalScore : MonoBehaviour
{
	private UIManager	m_UiManager;	// UI管理器
	private TextMesh	m_TextMesh;		// 分数组件

	void Start()
	{
		// 获取UI脚本
		m_UiManager = GameObject.Find("UI").GetComponent<UIManager>();
		// 获取分数组件
		m_TextMesh = gameObject.GetComponent<TextMesh>();
	}

	// Update is called once per frame
	void Update()
	{
		// 更新分数
		int nScore = m_UiManager.GetScore();
		m_TextMesh.text = "总分数：" + nScore.ToString() + "分";
	}
}

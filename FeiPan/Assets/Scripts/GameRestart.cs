using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRestart : MonoBehaviour
{
	private UIManager		m_UiManager;	// Ui脚本

	void Start()
	{
		// 获取UI脚本
		m_UiManager = GameObject.Find("UI").GetComponent<UIManager>();
	}

	// Update is called once per frame
	void OnMouseDown()
	{
		Debug.Log("GameRestart OnMouseDown");
		// 响应鼠标左键点击事件
		m_UiManager.ChangeGameState(UIManager.GAME_STATE.START);
	}
}

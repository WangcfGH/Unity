using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
	private UIManager		m_UiManager;		// UI管理器

	void Start()
	{
		// 获取UI管理器
		m_UiManager = GameObject.Find("UI").GetComponent<UIManager>();
	}

	void Update()
	{
		// 响应游戏开始
		if (Input.GetMouseButtonDown(0))
		{
			m_UiManager.ChangeGameState(UIManager.GAME_STATE.PLAYING);
		}
	}
}

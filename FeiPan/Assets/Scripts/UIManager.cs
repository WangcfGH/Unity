using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
	public enum GAME_STATE{START, PLAYING, END};

	private GameObject		m_UiStart;			// 游戏开始UI
	private GameObject		m_UiGame;			// 游戏进行UI
	private GameObject		m_UiEnd;			// 游戏结束UI
	private AudioSource		m_AudioSourceStart;	// 游戏开始声音源
	private Weapon			m_Weapon;			// 武器脚本
	private FeiPanManager	m_FeiPanManager;	// 飞盘管理器脚本

	void Start()
	{
		// 获取UI节点
		m_UiStart = GameObject.Find("StartUI");
		m_UiGame = GameObject.Find("GameUI");
		m_UiEnd = GameObject.Find("EndUI");

		// 获取游戏开始声音源
		m_AudioSourceStart = Camera.main.GetComponent<AudioSource>();

		// 获取武器脚本
		m_Weapon = GameObject.Find("Weapon").GetComponent<Weapon>();
		// 获取飞盘管理器脚本
		m_FeiPanManager = GameObject.Find("FeiPanManager").GetComponent<FeiPanManager>();

		// 设置游戏为开始状态
		ChangeGameState(GAME_STATE.START);
	}

	/// <summary>
	/// 改变游戏状态
	/// </summary>
	/// <param name="state"></param>
	public void ChangeGameState(GAME_STATE state)
	{
		if (state == GAME_STATE.START)
		{
			// UI界面状态切换
			m_UiStart.SetActive(true);
			m_UiGame.SetActive(false);
			m_UiEnd.SetActive(false);
			// 背景音乐状态切换
			m_AudioSourceStart.Stop();
			// 武器状态切换
			m_Weapon.ChangeMoveState(false);
			// 飞盘定时器状态切换
			m_FeiPanManager.StopCreateFeiPan();
		}
		else if (state == GAME_STATE.PLAYING)
		{
			// UI界面状态切换
			m_UiStart.SetActive(false);
			m_UiGame.SetActive(true);
			m_UiEnd.SetActive(false);
			// 背景音乐状态切换
			m_AudioSourceStart.Play();
			// 武器状态切换
			m_Weapon.ChangeMoveState(true);
			// 飞盘定时器状态切换
			m_FeiPanManager.StartCreateFeiPan();
		}
		else if (state == GAME_STATE.END)
		{
			// UI界面状态切换
			m_UiStart.SetActive(false);
			m_UiGame.SetActive(false);
			m_UiEnd.SetActive(true);
			// 背景音乐状态切换
			m_AudioSourceStart.Stop();
			// 武器状态切换
			m_Weapon.ChangeMoveState(false);
			// 飞盘定时器状态切换
			m_FeiPanManager.StopCreateFeiPan();
		}
	}
}

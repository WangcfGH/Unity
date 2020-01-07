using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
	private Ray				m_Ray;				// 射线
	private RaycastHit		m_RaycastHit;		// 射线碰撞信息
	private Transform		m_Transform;		// 手臂位置组件
	private Transform		m_LineTrans;		// LineRender位置组件
	private LineRenderer	m_LineRenderer;		// LineRender
	private AudioSource		m_SheJiAudioSource;	// 射击声音源
	private bool			m_bCanMove;			// 是否可以移动
	private int				m_nScore;			// 分数

	void Start()
	{
		// 获取LineRender
		m_Transform = gameObject.GetComponent<Transform>();
		m_SheJiAudioSource = gameObject.GetComponent<AudioSource>();
		m_LineTrans = m_Transform.Find("ShooterLine");
		m_LineRenderer = m_LineTrans.gameObject.GetComponent<LineRenderer>();
		m_nScore = 0;
	}

	void Update()
	{
		// 校验是否可以移动
		if (m_bCanMove)
		{
			// 检测射线碰撞
			m_Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(m_Ray, out m_RaycastHit))
			{
				// 调整手臂位置朝向
				m_Transform.LookAt(m_RaycastHit.point);

				// 设置LineRender起始和终止位置
				m_LineRenderer.SetPosition(0, m_LineTrans.position);
				m_LineRenderer.SetPosition(1, m_RaycastHit.point);

				// 射线碰撞到飞盘并且鼠标左键按下
				if (m_RaycastHit.collider.gameObject.tag == "FeiPan" && Input.GetMouseButtonDown(0))
				{
					// 播放射击声音
					m_SheJiAudioSource.Play();

					// 所有飞盘子类添加刚体组件并在2s后销毁
					GameObject feipan = m_RaycastHit.collider.gameObject.GetComponentInParent<Transform>().parent.gameObject;
					Transform[] feiPanChildsTrans = feipan.GetComponentsInChildren<Transform>();
					for (int i = 0; i < feiPanChildsTrans.Length; i++)
					{
						feiPanChildsTrans[i].gameObject.AddComponent<Rigidbody>();
					}
					GameObject.Destroy(feipan.gameObject, 2);

					// 更新分数值
					m_nScore = m_nScore + 1;
				}
			}
		}
	}

	/// <summary>
	/// 改变移动状态
	/// </summary>
	/// <param name="bCanMove"></param>
	public void ChangeMoveState(bool bCanMove)
	{
		m_bCanMove = bCanMove;
	}

	/// <summary>
	/// 获取分数
	/// </summary>
	/// <returns></returns>
	public int GetScore()
	{
		return m_nScore;
	}

	/// <summary>
	/// 设置分数
	/// </summary>
	/// <param name="nScore"></param>
	public void SetScore(int nScore)
	{
		m_nScore = nScore;
	}
}

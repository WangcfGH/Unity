using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeiPanManager : MonoBehaviour
{
	public GameObject		m_prefabFeiPan;		// 飞盘预制体

	private Transform		m_Transform;		// 位置组件

	void Start()
	{
		// 获取位置组件
		m_Transform = gameObject.GetComponent<Transform>();
	}

	/// <summary>
	/// 创建飞盘
	/// </summary>
	void CreateFeiPan()
	{
		for (int i = 0; i < 5; i++)
		{
			GameObject feiPan = GameObject.Instantiate(m_prefabFeiPan, new Vector3(Random.Range(-7.0f, 7.0f), Random.Range(0.5f, 4.0f), Random.Range(5.0f, 10.0f)), Quaternion.identity);
			feiPan.GetComponent<Transform>().SetParent(m_Transform);
		}
	}

	/// <summary>
	/// 销毁飞盘
	/// </summary>
	void DestroyFeiPan()
	{
		if (m_Transform)
		{
			Transform[] feiPans = m_Transform.GetComponentsInChildren<Transform>();
			for (int i = 1; i < feiPans.Length; i++)
			{
				GameObject.Destroy(feiPans[i].gameObject);
			}
		}
	}

	/// <summary>
	/// 开始创建飞盘
	/// </summary>
	public void StartCreateFeiPan()
	{
		// 销毁已有飞盘
		DestroyFeiPan();

		// 启动创建飞盘定时器函数
		InvokeRepeating("CreateFeiPan", 1.0f, 3.0f);
	}

	/// <summary>
	/// 停止创建飞盘
	/// </summary>
	public void StopCreateFeiPan()
	{
		// 销毁已有飞盘
		DestroyFeiPan();

		// 取消创建飞盘定时器函数
		CancelInvoke("CreateFeiPan");
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTotalScore : MonoBehaviour
{
	private Weapon		m_Weapon;		// 武器脚本
	private TextMesh	m_TextMesh;		// 分数组件

	void Start()
	{
		// 获取武器脚本
		m_Weapon = GameObject.Find("Weapon").GetComponent<Weapon>();
		// 获取分数组件
		m_TextMesh = gameObject.GetComponent<TextMesh>();
	}

	// Update is called once per frame
	void Update()
	{
		int nScore = m_Weapon.GetScore();
		m_TextMesh.text = "总分数：" + nScore.ToString() + "分";
	}
}
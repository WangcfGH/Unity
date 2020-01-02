using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLifeTest : MonoBehaviour
{
    // 唤醒：生命周期内执行一次
    void Awake()
    {
        Debug.Log("Awake");
    }

    // 启用：生命周期内可多次执行，启用就执行一次
    void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    // 开始：生命周期内执行一次
    void Start()
    {
        Debug.Log("Start");
    }

    // 固定更新：生命周期内反复执行，默认每隔0.02s执行一次
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    // 刷新：生命周期内反复执行，每帧调用一次
    void Update()
    {
        Debug.Log("Update");
    }

    // 稍后刷新：生命周期内反复执行，每帧调用一次，在Update之后调用
    void LateUpdate()
    {
        Debug.Log("LastUpdate");
    }

    // GUI刷新：生命周期内反复执行，基本为Update的2倍
    void OnGUI()
    {
        Debug.Log("OnGUI");
    }

    // 禁用：生命周期内可多次执行，禁用就执行一次
    void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    // 销毁：生命周期内执行一次
    void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}

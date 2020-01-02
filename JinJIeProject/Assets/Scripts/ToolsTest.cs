using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsTest : MonoBehaviour
{
    private float fNum = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // Time工具类
        //Debug.Log("Time:" + Time.time);
        //Debug.Log("deltaTime:" + Time.deltaTime);
        //Time.timeScale = 2;

        // Math工具类
        //fNum = Mathf.Lerp(fNum, 1.0f, 0.02f);
        //Debug.Log("Lerp:" + fNum);

        // Screen工具类
        Debug.Log("Screen width is:" + Screen.width);
        Debug.Log("Screen height is:" + Screen.height);
    }
}

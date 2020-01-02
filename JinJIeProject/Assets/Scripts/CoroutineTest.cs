using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Task1");
        Debug.Log("Task2");
        //Debug.Log("Task3");
        StartCoroutine("CoroutineTask");
        Debug.Log("Task4");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            StopCoroutine("CoroutineTask");
        }
    }

    IEnumerator CoroutineTask()
    {
        yield return new WaitForSeconds(2);
        Debug.Log("Task3");
        
        yield return new WaitForSeconds(2);
        Debug.Log("Task5");
    }
}

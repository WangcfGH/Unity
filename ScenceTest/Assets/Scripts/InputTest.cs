using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Input GetKey:A");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Input GetKeyDown:A");
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("Input GetKeyUp:A");
        }

        if (Input.GetMouseButton(0))
        {
            Debug.Log("Input GetMouseButton:left");
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Input GetMouseButtonDown:left");
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Input GetMouseButtonUp:left");
        }
    }
}

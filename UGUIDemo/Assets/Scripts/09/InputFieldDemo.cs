using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldDemo : MonoBehaviour {

    private InputField      m_InputField;

	void Start () 
    {
        m_InputField = gameObject.GetComponent<InputField>();
	
        m_InputField.onValueChanged.AddListener(OnValueChanged);

        m_InputField.onEndEdit.AddListener(OnEditEnd);
	}

    private void OnValueChanged(string value)
    {
        Debug.Log("OnValueChanged " + value);
    }

    private void OnEditEnd(string value)
    {
        Debug.Log("OnEditEnd " + value);
    }
}

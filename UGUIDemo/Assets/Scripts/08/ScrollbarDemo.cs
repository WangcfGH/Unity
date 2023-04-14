using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollbarDemo : MonoBehaviour 
{
    private Scrollbar       m_Scrollbar;

	void Start () 
    {
        m_Scrollbar = gameObject.GetComponent<Scrollbar>();
        m_Scrollbar.onValueChanged.AddListener(ScrollbarValueChange);
	}

    private void ScrollbarValueChange(float fValue)
    {
        Debug.Log("Scrollbar Value Is "+ fValue);
    }
}

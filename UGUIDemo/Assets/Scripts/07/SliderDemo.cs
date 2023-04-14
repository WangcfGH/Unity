using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderDemo : MonoBehaviour 
{
    private Slider      m_Slider;

	void Start () 
    {
        m_Slider = gameObject.GetComponent<Slider>();
        m_Slider.onValueChanged.AddListener(OnValueChange);
	}


    private void OnValueChange(float fValue)
    {
        Debug.Log("Slider Value Is " + fValue);
    }
    
}

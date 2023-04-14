using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EventDemo : MonoBehaviour {

	void Start () {
		
	}
	
    public void PointerEnter(BaseEventData eventData)
    {
        Debug.Log("PointerEnter");
    }

    public void PointerExit(BaseEventData eventData)
    {
        Debug.Log("PointerExit");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollRectDemo : MonoBehaviour {

    private ScrollRect  m_ScrollRect;

	void Start () {
        m_ScrollRect = gameObject.GetComponent<ScrollRect>();
        m_ScrollRect.onValueChanged.AddListener(OnScrollRectValueChange);
	}

    private void OnScrollRectValueChange(Vector2 v)
    {
        Debug.Log("H:" + v.x + "        V:" + v.y);
    }
}

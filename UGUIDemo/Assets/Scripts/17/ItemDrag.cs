using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemDrag : MonoBehaviour,IBeginDragHandler, IDragHandler, IEndDragHandler {
    private RectTransform m_RectTransform;

	void Start () {
        m_RectTransform = gameObject.GetComponent<RectTransform>();	
	}

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        Vector3 pos;
        RectTransformUtility.ScreenPointToWorldPointInRectangle(m_RectTransform, eventData.position, eventData.enterEventCamera, out pos);
        m_RectTransform.position = pos;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
    }
}

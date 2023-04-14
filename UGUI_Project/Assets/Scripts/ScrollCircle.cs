using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

delegate string MyDelegate(string message);

public class ScrollCircle : ScrollRect
{
    private float   m_Radius        = 0.0f;
    private Vector2 m_ForceVector   = Vector2.zero;
    private Button  m_Button;

    static void TWrite(string message)

    {
        Debug.Log(message + "this is using named method");
    }

    // Start is called before the first frame update
    void Start()
    {
        //MyDelegate tempDelegate = TWrite;
        m_Radius = (transform as RectTransform).sizeDelta.x * 0.5f;
        m_ForceVector = Vector2.zero;        
    }

    public override void OnDrag(PointerEventData eventData)
    {
        base.OnDrag(eventData);

        Vector2 anchoreP = this.content.anchoredPosition;
        if (anchoreP.magnitude > m_Radius)
        {
            anchoreP = anchoreP.normalized * m_Radius;
            SetContentAnchoredPosition(anchoreP);
        }
        m_ForceVector = anchoreP.normalized;
        Debug.Log("方向向量：" + m_ForceVector);
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        base.OnEndDrag(eventData);
        m_ForceVector = Vector2.zero;
    }

}

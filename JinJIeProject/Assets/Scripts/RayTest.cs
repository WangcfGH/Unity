using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest : MonoBehaviour
{
    private Ray         m_Ray;
    private RaycastHit  m_RaycastHit;

    // Update is called once per frame
    void Update()
    {
        CameraSendRay();
    }

    /// <summary>
    /// 按下鼠标左键发射射线
    /// </summary>
    void CameraSendRay()
    {
        if (Input.GetMouseButtonDown(0))
        {
            m_Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(m_Ray, out m_RaycastHit))
            {
				Debug.DrawRay(gameObject.transform.position, m_RaycastHit.point - gameObject.transform.position, Color.red);
                GameObject.Destroy(m_RaycastHit.collider.gameObject);
            }
        }
    }
}

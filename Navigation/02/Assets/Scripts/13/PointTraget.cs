using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTraget : MonoBehaviour 
{
    public int  m_nIndex;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            SendMessageUpwards("TriggerGuideEffect", m_nIndex);   
        }
    }
}

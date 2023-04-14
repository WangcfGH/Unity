using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRenderEffect: MonoBehaviour 
{
    public int      m_nSpeed;

	void Update () 
    {
        gameObject.GetComponent<LineRenderer>().materials[0].SetTextureOffset("_MainTex", new Vector2(Time.time * m_nSpeed, 0));
	}
}

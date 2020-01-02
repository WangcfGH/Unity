using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeiPanManager : MonoBehaviour
{
	public GameObject		m_prefabFeiPan;

	private Transform		m_Transform;

    // Start is called before the first frame update
    void Start()
    {
		m_Transform = gameObject.GetComponent<Transform>();
		InvokeRepeating("CreateFeiPan", 1.0f, 3.0f);
    }

	void CreateFeiPan()
	{
		for (int i = 0; i < 5; i++)
		{
			GameObject feiPan = GameObject.Instantiate(m_prefabFeiPan, new Vector3(Random.Range(-8.0f, 8.0f), Random.Range(0.5f, 5.0f), Random.Range(5.0f, 15.0f)), Quaternion.identity);
			feiPan.GetComponent<Transform>().SetParent(m_Transform);
		}
	}
}

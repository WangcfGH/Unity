using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackBag : MonoBehaviour {
    private GameObject      m_ItemPrefeb;
    private RectTransform   m_GridRectTransform;
	
	void Awake () {
        m_ItemPrefeb = Resources.Load<GameObject>("Prefebs/Item");
        m_GridRectTransform = GameObject.Find("Grid").GetComponent<RectTransform>();
        CreateAllItem();
	}

    private void CreateAllItem()
    {
        for (int i = 0; i < 50; i++)
        {
            Item item = GameObject.Instantiate<GameObject>(m_ItemPrefeb, m_GridRectTransform).GetComponent<Item>();
            item.SetValue(Random.RandomRange(10, 100), Random.RandomRange(1, 10));
        }
    }
}

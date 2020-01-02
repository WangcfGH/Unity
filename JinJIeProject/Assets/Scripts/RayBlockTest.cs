using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayBlockTest : MonoBehaviour
{
    private const int nWallWidth    = 10;
    private const int nWallHeight   = 5;

	private Ray						m_Ray;
	private RaycastHit				m_RaycastHit;

	public GameObject				m_PrefabBlock;
	public GameObject				m_PrefabBullet;

    // Start is called before the first frame update
    void Start()
    {
        CreateWall(nWallWidth, nWallHeight);
    }

    // Update is called once per frame
    void Update()
    {
		SendBullet();
    }

    /// <summary>
    /// 创建墙体
    /// </summary>
    void CreateWall(int nWidth, int nHeight)
    {
        for (int i = 0; i < nWallWidth; i++)
        {
            for (int j = 0; j < nWallHeight; j++)
			{
				GameObject.Instantiate(m_PrefabBlock, new Vector3(i - 5.0f, j + 0.5f, 3.0f), Quaternion.identity);
			}
        }
    }

	/// <summary>
	/// 发射子弹
	/// </summary>
	void SendBullet()
	{
		if (Input.GetMouseButtonDown(0))
		{
			m_Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(m_Ray, out m_RaycastHit))
			{
				GameObject go = GameObject.Instantiate(m_PrefabBullet, Camera.main.transform.position, Quaternion.identity);
				Vector3 direct = m_RaycastHit.point - Camera.main.transform.position;

				Debug.DrawRay(Camera.main.transform.position, direct, Color.red);

				go.GetComponent<Rigidbody>().AddForce(direct * 100, ForceMode.Force);
			}
		}
	}
}

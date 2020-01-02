using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreateBoxs : MonoBehaviour
{
    private const int   CREAT_BOX_NUM       = 5;
    private const float MIN_X               = -9.0f;
    private const float MAX_X               = 9.0f;
    private const float MIN_Y               = 10.0f;
    private const float MAX_Y               = 15.0f;
    private const float MIN_Z               = -9.0f;
    private const float MAX_Z               = 9.0f;
    public GameObject m_prefabBox;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateBox", 3.0f, 2.0f);
        Invoke("DestroyCreatBox", 20.0f);
    }

    bool CreateBox()
    {
        for (int i = 0; i < CREAT_BOX_NUM; i++)
        {
            float nX = Random.Range(MIN_X, MAX_X);
            float nY = Random.Range(MIN_Y, MAX_Y);
            float nZ = Random.Range(MIN_Z, MAX_Z);
            GameObject.Instantiate(m_prefabBox, new Vector3(nX, nY, nZ), Quaternion.identity);
        }
        return true;
    }

    void DestroyCreatBox()
    {
        CancelInvoke("CreateBox");
    }
}

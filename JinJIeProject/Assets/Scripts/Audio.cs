using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    AudioSource m_AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        m_AudioSource = gameObject.GetComponent<AudioSource>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            m_AudioSource.Play();
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            m_AudioSource.Stop();
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            m_AudioSource.Pause();
        }
    }
}

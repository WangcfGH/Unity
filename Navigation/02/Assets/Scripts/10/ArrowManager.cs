using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : MonoBehaviour 
{
    Transform m_transform;
    ParticleSystem[] m_ArrowParticleSystems;

	void Awake () 
    {
        m_transform = gameObject.GetComponent<Transform>();
        m_ArrowParticleSystems = m_transform.GetComponentsInChildren<ParticleSystem>();
        //PlayArrowParticle();
	}

    public void PlayArrowParticle()
    {
        for (int i = 0; i < m_ArrowParticleSystems.Length; i++)
        {
            m_ArrowParticleSystems[i].Play();
        }
    }
}

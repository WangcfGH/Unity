using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour 
{
    private float           m_Distance;
    private string          m_TargetName;
    private Transform       m_Transform;
    private Transform       m_PlayerTransform;
    private NavMeshAgent    m_Navgation;
    private Animator        m_Animator;
    private bool            m_Alive;

	void Awake () 
    {
        m_Transform = gameObject.GetComponent<Transform>();
        m_Navgation = gameObject.GetComponent<NavMeshAgent>();
        m_Animator = gameObject.GetComponent<Animator>();
        m_Alive = true;
	}

    public  void SetTarget(string targetName, float distance)
    {
        m_TargetName = targetName;
        m_Distance = distance;
        m_PlayerTransform = GameObject.Find(m_TargetName).GetComponent<Transform>();
        m_Navgation.stoppingDistance = m_Distance;
        m_Navgation.SetDestination(m_PlayerTransform.position);

        StartCoroutine("FollowTarget");
    }

    IEnumerator FollowTarget()
    {
        while (m_Alive)
        {
            if (Vector3.Distance(m_Transform.position, m_PlayerTransform.position) > m_Distance)
            {
                m_Animator.SetBool("Attack", false);
                m_Navgation.SetDestination(m_PlayerTransform.position);
            }
            else
            {
                m_Animator.SetBool("Attack", true);
            }

            yield return new WaitForSeconds(0.5f);   
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovePlayer : MonoBehaviour
{
    public GameObject m_prefabParticleSystem;
    public GameObject m_prefabTrap;

    private NavMeshAgent m_navMeshAgent;
    private RaycastHit m_rayCastHit;
    private Animator m_animator;

    void Start()
    {
        m_navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
        m_animator = gameObject.GetComponent<Animator>();
        //Transform end = GameObject.Find("End").GetComponent<Transform>();
        //m_navMeshAgent.SetDestination(end.position);
        //m_navMeshAgent.destination = end.position;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out m_rayCastHit))
            {
                m_navMeshAgent.destination = m_rayCastHit.point;
                PlayArrowParticle(m_rayCastHit.point);
            }
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            Trap(gameObject.GetComponent<Transform>().position, m_prefabTrap);
        }

        //RunOrIdle();
    }

    private void PlayArrowParticle(Vector3 pointPos)
    {
        Vector3 temp = pointPos + new Vector3(0, 0.8f, 0);
        GameObject go = GameObject.Instantiate(m_prefabParticleSystem, temp, Quaternion.identity);
        go.GetComponent<ArrowManager>().PlayArrowParticle();
        GameObject.Destroy(go, 1);
    }

    private void RunOrIdle()
    {
        if (Mathf.Abs(m_navMeshAgent.remainingDistance) <= 0.1f)
        {
            m_animator.SetBool("Run", false);
        }
        else
        {
            m_animator.SetBool("Run", true);
        }
    }

    private void Trap(Vector3 pos, GameObject prefebTrap)
    {
        GameObject trapParent = GameObject.Find("Traps");
        GameObject tempTrap = GameObject.Instantiate<GameObject>(prefebTrap, pos + new Vector3(0, 0.4f, 0), Quaternion.identity);
        tempTrap.GetComponent<Transform>().SetParent(trapParent.GetComponent<Transform>());
        SphereCollider sc = tempTrap.AddComponent<SphereCollider>();
        sc.isTrigger = true;
        sc.radius = 0.8f;
        tempTrap.AddComponent<Trap>();

        GameObject.Destroy(tempTrap, 5.0f);
    }
}

using UnityEngine;
using System.Collections;

public class KinghtPlayer : MonoBehaviour 
{
    public float                    m_Speed;        // 速度
    public AudioClip                m_FootStep;     // 脚步声
    public Transform                m_TransforIK;   // IK物体

    private bool                    m_StartIK;      // 开启IK
    private CharacterController     m_CC;           // 角色控制器
    private Animator                m_Ani;          // 角色动画器
    private Transform               m_Transform;    // 角色位置组件

	// Use this for initialization
	void Start () 
    {
        m_CC = gameObject.GetComponent<CharacterController>();
        m_Ani = gameObject.GetComponent<Animator>();
        m_Transform = gameObject.GetComponent<Transform>();
        m_StartIK = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(h, 0, v);

        if (Mathf.Abs(h) > 0.1f || Mathf.Abs(v) > 0.1f)     // 开始走或跑
        {
            m_Transform.LookAt(m_Transform.position + dir);
            
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                // 开始跑
                m_Ani.SetBool("walk", false);
                m_Ani.SetBool("run", true);
            }
            else if (Input.GetKeyUp(KeyCode.LeftControl))
            {
                // 开始走
                m_Ani.SetBool("run", false);
                m_Ani.SetBool("walk", true);
            }
            else if (!m_Ani.GetBool("run"))
            {
                // 没在跑就开始走
                m_Ani.SetBool("walk", true);
            }

            if (m_Ani.GetBool("run"))
            {
                m_CC.SimpleMove(dir);
            }

            if (m_Ani.GetBool("walk"))
            {
                m_CC.SimpleMove(dir);
            }
        }
        else                                                // 停止走、停止跑
        {
            m_Ani.SetBool("walk", false);
            m_Ani.SetBool("run", false);
        }

        //-----------------------------攻击---------------------------------
        if (Input.GetKeyDown(KeyCode.F1))
        {
            m_Ani.SetTrigger("attack1");
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            m_Ani.SetTrigger("attack2");
        }

        if (Input.GetKeyDown(KeyCode.F3))
        {
            m_Ani.SetTrigger("attack3");
        }

        if (Input.GetKeyDown(KeyCode.F4))
        {
            m_Ani.SetTrigger("attack4");
        }

        if (Input.GetKeyDown(KeyCode.F5))
        {
            m_Ani.SetTrigger("attack5");
        }

        if (Input.GetKeyDown(KeyCode.F6))
        {
            m_Ani.SetTrigger("attack6");
        }
        //-----------------------------攻击---------------------------------

        //-----------------------------连招---------------------------------
        if (Input.GetKeyDown(KeyCode.F))
        {
            m_Ani.SetTrigger("attack1to2");
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            m_Ani.SetTrigger("attack2to4");
        }
        //-----------------------------连招---------------------------------

        //-----------------------------一键连招---------------------------------
        if (Input.GetMouseButtonDown(0))
        {
            m_Ani.SetTrigger("attack1-2-3");
        }
        //-----------------------------一键连招---------------------------------

        //-----------------------------IK---------------------------------
        if (Input.GetKeyDown(KeyCode.L))
        {
            m_StartIK = !m_StartIK;
        }
        //-----------------------------IK---------------------------------

        //-----------------------------分层---------------------------------
        if (Input.GetKeyDown(KeyCode.M))
        {
            m_Ani.SetTrigger("shoot");
        }
        //-----------------------------分层---------------------------------

	}

    private void OnAnimatorIK(int index)
    {
        if (m_StartIK)
        {
            m_Ani.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
            m_Ani.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1);

            m_Ani.SetIKPosition(AvatarIKGoal.LeftHand, m_TransforIK.position);
            m_Ani.SetIKRotation(AvatarIKGoal.LeftHand, m_TransforIK.rotation);    
        }
    }

    private void AttackEvent()
    {
        Debug.Log("Attack1 Doing...");
    }

    private void FootStep()
    {
        AudioSource.PlayClipAtPoint(m_FootStep, m_Transform.position);
    }
}

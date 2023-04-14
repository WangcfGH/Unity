using UnityEngine;
using System.Collections;

public class Robot : MonoBehaviour {

    public Animator m_Animator;

	// Use this for initialization
	void Start () {
        m_Animator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        m_Animator.SetFloat("Vertical", v);
        m_Animator.SetFloat("Horizontal", h);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_Animator.SetBool("Jump", true);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            m_Animator.SetBool("Jump", false);
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            m_Animator.SetBool("Ctrl", true);
        }

        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            m_Animator.SetBool("Ctrl", false);
        }

        if (Input.GetMouseButtonDown(0))
        {
            m_Animator.SetBool("Mouse", true);
        }

        if (Input.GetMouseButtonUp(0))
        {
            m_Animator.SetBool("Mouse", false);
        }

        if (Input.GetMouseButtonDown(1))
        {
            m_Animator.SetTrigger("JumpTrigger");
        }
	}
}

using UnityEngine;
using System.Collections;

public class LionPlayer : MonoBehaviour {
    //private Animator m_Animator;
    private Animation m_Animation;

	// Use this for initialization
	void Start () {
        //m_Animator = gameObject.GetComponent<Animator>();
        m_Animation = gameObject.GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
        m_Animation.Play("Run");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_Animation.Play(AnimationPlayMode.Stop);
            //m_Animator.SetTrigger("attack");
        }

	}
}

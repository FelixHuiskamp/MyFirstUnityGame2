using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Animator m_Animator;
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.Mouse0))
        {
            m_Animator.ResetTrigger("Idle");

            m_Animator.SetTrigger("Dance");
        }
    }
}

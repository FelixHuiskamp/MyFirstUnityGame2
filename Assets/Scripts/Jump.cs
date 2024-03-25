using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEditorInternal;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float force = 20f;
    private Rigidbody rb;
    public float jumpAmount = 10;
    public float GravityScale = 1f;
    public float fallingGravityScale = 40;
    bool onFloor = false;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
      
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            onFloor = true;
            
        }

        
    }


    void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.Space) && onFloor == true)
        {
            Debug.Log("space key was pressed");
            rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
            onFloor = false;
            
        }
        

    }

}

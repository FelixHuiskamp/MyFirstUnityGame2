using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float force = 20f;
    private Rigidbody rb;
    public float jumpAmount = 10;
    public float GravityScale = 1f;
    public float fallingGravityScale = 40;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.AddForce(Physics.gravity * (GravityScale - 1) * rb.mass);
    }




    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space key was pressed");
            rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
        }
        

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPickUp : MonoBehaviour
{
    Renderer r;
    AudioSource Pop;
    
    ParticleSystem ps; 
    void Start()
    {
        Pop = GetComponent<AudioSource>();
        r = GetComponent<Renderer>();

        

        ps = GetComponent<ParticleSystem>();

        ps.Stop();
    }

   

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("!");
        if (other.tag == "Player")
        {
            r.enabled = false;
            GameObject.Destroy(gameObject, 0.5f);
            Pop.Play();
            ps.Play();
            
            
        }
    }

   

 
   void DestroyGameObject()
   {
       GameObject.Destroy(gameObject, 0.5f);
   }




    
    void Update()
    {
        
        

    }


}

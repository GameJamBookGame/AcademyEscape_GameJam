using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeBook : MonoBehaviour
{
      void Update() {
    Debug.Log("denemöe");    
     }

     private void OnCollisionEnter(Collision collision) {
        Debug.Log("çarpışma var");
       
         
             Destroy(this.gameObject);
        
    /**
     private void OnTriggerEnter(Collision collision)
    {

        Destroy(gameObject);
        Debug.Log("Oğe silindi.");
        // Eğer bu nesne bir "Player" nesnesiyle çarpışırsa, nesneyi yok et
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
             if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gameObject);
            Debug.Log("Oğe silindi.");
        }
    }*/
        }     
        }
    


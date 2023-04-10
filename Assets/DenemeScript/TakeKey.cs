using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeKey : MonoBehaviour
{
    public bool takeKey = false;
    // Start is called before the first frame update
    
     private void OnCollisionEnter(Collision collision) {
        Debug.Log("çarpışma var");
       Debug.Log(takeKey);
         if (Input.GetKey(KeyCode.F))
        {
                takeKey =true;
                Destroy(this.gameObject);
                Debug.Log(takeKey);
             
             
        }
}
}

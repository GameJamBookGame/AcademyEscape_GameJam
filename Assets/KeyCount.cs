using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyCount : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] public TMP_Text _text;
    public int count = 0;
   [SerializedField] public GameObject kapi;
   [SerializedField] public GameObject kapi2;
   


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(" anahtara temas var");
       
        if (other.gameObject.CompareTag("key"))
        {
            count++;
            if(count==1){
                _text.text = count.ToString();
                Destroy(other.gameObject);
                Destroy(kapi);
            }
             if(count==2){
                _text.text = count.ToString();
                Destroy(other.gameObject);
                Destroy(kapi2);
            }
           
            
           
            
            
            
        }

    }
}

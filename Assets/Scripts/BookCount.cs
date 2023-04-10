using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class BookCount : MonoBehaviour
{
    [SerializeField] public TMP_Text _text;
    public int count = 0;
    [SerializedField] public GameObject theEnd;
    private float timer = 0f;
    private float delay= 3f;

    void Update() {
        if(count == 6){
            timer += Time.deltaTime;
            Debug.Log(timer);
            }
            if (timer >= delay)
        {
             SceneManager.LoadScene("StartScene");
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        
        Debug.Log("çarpışma var");
        if (other.gameObject.CompareTag("book"))
        {
            Destroy(other.gameObject);
            count++;
            _text.text = count.ToString();
            if(count == 6){
                
             timer += Time.deltaTime;
                theEnd.SetActive(true);
           
                

            }
             
        }

    }
}
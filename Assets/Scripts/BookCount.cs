using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BookCount : MonoBehaviour
{
    [SerializeField] public TMP_Text _text;
    public int count = 0;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("book"))
        {
            Destroy(other.gameObject);
            count++;
            _text.text = count.ToString();
        }

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimControl : MonoBehaviour
{
    public GameObject door;
    public GameObject key;
    public float interactionDistance = 3f;

    private Animator doorAnimator;
    private bool Key = false;

    void Start()
    {
        doorAnimator = door.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            float distanceToDoor = Vector3.Distance(transform.position, door.transform.position);
            if (distanceToDoor <= interactionDistance && Key)
            {
                doorAnimator.SetBool("Key", true);
                Destroy(key);
            }
            else if (distanceToDoor <= interactionDistance && !Key)
            {
                Debug.Log("Kapıyı açmak için anahtara ihtiyacınız var!");
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == key)
        {
            Debug.Log("Anahtarı aldınız!");
            Key = true;
            Destroy(key);
        }
    }
}

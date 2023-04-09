using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMevement : MonoBehaviour
{
   Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            anim.SetBool("Chrouch", true);
         
        }else{
            anim.SetBool("Chrouch", false);
        }
        
    }
}


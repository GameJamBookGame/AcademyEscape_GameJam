using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class Countdown : MonoBehaviour
{
    public Text countdownText;
    public float countdownTime = 30f;
    [SerializeField] public TMP_Text _text;



    public void Start()
    {
        InvokeRepeating("UpdateCountdown", 0f, 1f);
    }

    public void UpdateCountdown()
    {
        countdownTime--;
        countdownText.text = countdownTime.ToString();
        if (countdownTime <= 0f)
        {
            CancelInvoke("UpdateCountdown");
            countdownText.text = "0";
        }
    }
}
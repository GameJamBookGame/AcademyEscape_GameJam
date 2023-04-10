using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class TimeCount : MonoBehaviour
{
  
    [SerializedField] public GameObject _gameOver;
    [SerializedField] public GameObject _fadePanel;
    [SerializedField] public GameObject _gameOverFrame;
    [SerializedField] public GameObject _playAgainButton;
    [SerializedField] public GameObject _exitButton;
    [SerializeField] public TMP_Text _text;
    public int count = 30;
    private float timer = 0f;
    private float delay= 20f;
   

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        if(timer >= delay){
            timer = 0f;
            count = count -1;
             _text.text = count.ToString();
            
        }
        if(count == 0){
            _gameOver.SetActive(true);
            _fadePanel.SetActive(true);
                _gameOverFrame.SetActive(true);
                _playAgainButton.SetActive(true);
                _exitButton.SetActive(true);
        }
    }
}

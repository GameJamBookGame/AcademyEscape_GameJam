using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{
    private int live = 3;
    [SerializedField] public GameObject[] _liveUI;
    [SerializedField] public GameObject _gameOver;
    [SerializedField] public GameObject _fadePanel;
    [SerializedField] public GameObject _gameOverFrame;
    [SerializedField] public GameObject _playAgainButton;
    [SerializedField] public GameObject _exitButton;



    private void OnCollisionEnter(Collider other)
    {
        Debug.Log("çarpýþma oldu");
        if (other.gameObject.CompareTag("enemy"))
        {
            live--;
            _liveUI[live].gameObject.SetActive(false);
            if (live == 0)
            {
                _gameOver.SetActive(true);
                _fadePanel.SetActive(true);
                _gameOverFrame.SetActive(true);
                _playAgainButton.SetActive(true);
                _exitButton.SetActive(true);
                StartCoroutine(Fade());
            }
        }
    }

    IEnumerator Fade()
    {
        yield return new WaitForSeconds(1.5f);
        Time.timeScale = 0;
    }


}
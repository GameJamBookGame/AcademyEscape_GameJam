using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneLoader : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("StartScene", LoadSceneMode.Single);
    }
}
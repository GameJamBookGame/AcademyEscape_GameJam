using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{
    public Button nextButton;

    public void Start()
    {
        nextButton.onClick.AddListener(LoadNextScene);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class VRMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MainScene"); // Change to actual scene name
    }

    public void QuitGame()
    {
        Application.Quit();

    }
}


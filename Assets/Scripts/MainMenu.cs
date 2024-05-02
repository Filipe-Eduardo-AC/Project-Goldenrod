using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadSceneAsync("Level 01");
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}

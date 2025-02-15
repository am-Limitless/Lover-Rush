using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPannel : MonoBehaviour
{
    public void play()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScene");
    }

    public void quit()
    {
        Application.Quit();
    }
}

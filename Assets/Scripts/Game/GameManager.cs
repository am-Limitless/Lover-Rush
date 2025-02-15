using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("UI Panels")]
    [SerializeField] private GameObject gameOverPannel;
    [SerializeField] private GameObject uiElements;
    [SerializeField] private GameObject pausePannel;

    /// Quits the application.
    public void Quit()
    {
        Application.Quit();
    }

    /// Displays the Game Over panel and hides UI elements.
    public void GameOver()
    {
        if (gameOverPannel != null) gameOverPannel.SetActive(true);
        if (uiElements != null) uiElements.SetActive(false);
    }

    /// Navigates to the Main Menu scene.
    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        LoadScene("MainMenu");
    }

    /// Pauses the game and displays the Pause panel.
    public void Pause()
    {
        Time.timeScale = 0f;
        if (pausePannel != null) pausePannel.SetActive(true);

    }

    /// Resumes the game and hides the Pause panel.
    public void Resume()
    {
        Time.timeScale = 1f;
        if (pausePannel != null) pausePannel.SetActive(false);
    }

    /// Restarts the current game scene.
    public void Replay()
    {
        LoadScene("MainScene");
        if (gameOverPannel != null) gameOverPannel.SetActive(false);
    }

    /// A helper method to load scenes by name.
    private void LoadScene(string sceneName)
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogWarning("Scene name is null or empty!");
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        Debug.Log("Loading Menu.........");
    }

    public void SaveGame()
    {
        
        PlayerPrefs.SetInt("Score", Score.CurrentScore);

        PlayerPrefs.SetInt("live", Score.CurrnetLive);

        PlayerPrefs.SetString("name", Name.theName);

        Debug.Log("Save Game........., Saved, Score: " + Score.CurrentScore + 
          ", live: " + Score.CurrnetLive + ", Name: " + Name.theName);
    }

    public void LoadGame()
    {
        Score.CurrentScore = PlayerPrefs.GetInt("Score");

        Score.CurrnetLive = PlayerPrefs.GetInt("live");

        Name.theName = PlayerPrefs.GetString("name");

        SceneManager.LoadScene("Game");
        Resume();

        Debug.Log("Loading Saved Game.........");
    }

    public void QuitGame()
    {
        Debug.Log("Quiting Game.......");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Application.Quit();
    }


}

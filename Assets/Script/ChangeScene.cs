using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
   public void GoBack ()
    {
        Score.CurrentScore = 0;
        Score.CurrnetLive = 1;
        SceneManager.LoadScene("Menu");
    }
    

    public void quitgame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }


}


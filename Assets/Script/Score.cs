using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int CurrentScore = 0;

    public static int CurrnetLive = 1;

    public Text scoreText;

    public Text liveText;

    void Start()
    {
        scoreText.text = CurrentScore.ToString();

        liveText.text = "Live left: " + CurrnetLive.ToString();
    }

}

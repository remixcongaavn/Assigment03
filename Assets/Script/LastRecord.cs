using UnityEngine;
using UnityEngine.UI;

public class LastRecord : MonoBehaviour
{

    public Text displayScore;
    public Text displayLive;
    void Start()
    {

        displayScore.text = "Last play Score: "+ Score.CurrentScore.ToString();

        displayLive.text = "Last PLay Live: " + Name.lastplayLive;
    }
}

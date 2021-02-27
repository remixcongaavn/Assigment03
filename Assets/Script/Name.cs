using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public static string theName;
    public GameObject inputField;
    public GameObject textDisplay;

    public static int lastplayLive = 1;

    public Dropdown liveDropdown;
    public Slider speedSlider;
    public Text speedDisplay;
    public void StoreName()
    {
        theName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Welcome " + theName + " to the game!!";
        Debug.Log("Update Name!");
    }

    public void changeLive()
    {
        switch (liveDropdown.value){
            default:
                Score.CurrnetLive = 1;
                lastplayLive = 1;

                break;
            case 0:
                Score.CurrnetLive = 1;
                lastplayLive = 1;

                break;
            case 1:
                Score.CurrnetLive = 2;
                lastplayLive = 2;

                break;
            case 2:
                Score.CurrnetLive = 3;
                lastplayLive = 3;
                break;

        }
    }

    public void changeSpeed(float value)
    {
        car.speed = speedSlider.value;
        speedDisplay.text = speedSlider.value.ToString("");
    }
}

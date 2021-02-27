using UnityEngine;
using UnityEngine.UI;

public class MoveName : MonoBehaviour
{
    public Text displayName;
  
    void Start()
    {
        displayName.text = "Name: " + Name.theName;

       
    }

    
}

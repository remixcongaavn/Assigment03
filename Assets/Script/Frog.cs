using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour
{
    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            rb.MovePosition(rb.position + Vector2.right);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            rb.MovePosition(rb.position + Vector2.left);
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.MovePosition(rb.position + Vector2.up);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            rb.MovePosition(rb.position + Vector2.down);
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag == "Car")
        {
            Score.CurrnetLive -= 1;
            SceneManager.LoadScene("Game");
        }

        if (Score.CurrnetLive == 0)
        {
            SceneManager.LoadScene("Exit");
        }

        else if (col.tag == "Obstacle")
        {
            Debug.Log("Restart position!!!!");

            this.gameObject.transform.position = new Vector2(0, -4);
        }
    }
}

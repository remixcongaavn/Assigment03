using UnityEngine;

public class car : MonoBehaviour
{
    public Rigidbody2D rb;

    public static float speed = 8f;



    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
    }


}

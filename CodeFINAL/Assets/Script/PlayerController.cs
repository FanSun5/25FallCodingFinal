using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    //private bool m_facingRight = true;
   
    private Rigidbody2D rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move();    
    }

    private void move()
    {
        float x_moveInput = Input.GetAxis("Horizontal");
        float y_moveInput = Input.GetAxis("Vertical");

        rb.linearVelocity = new Vector2(x_moveInput * moveSpeed, y_moveInput * moveSpeed);  
    }
}
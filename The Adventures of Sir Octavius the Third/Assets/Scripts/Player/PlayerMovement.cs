using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Variables")]
    public float maxSpeed = 100;
    public float jumpForce = 1400;
    public float acceleration = 25;
    public float groundFriction = 5;

    [Header("Ground Check")]
    public Transform groundCheckPoint;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private bool isGrounded;

    private bool JumpPressed = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            JumpPressed = true;
        }
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);

        float scaledAcceleration = acceleration * (1 - Mathf.Abs(rb.linearVelocity.x) / maxSpeed);

        //Apply the friction to the movement
        if (rb.linearVelocity.x > 0)
            rb.linearVelocity = new Vector2(rb.linearVelocity.x - Mathf.Min(groundFriction, rb.linearVelocity.x), rb.linearVelocity.y); //Velocity is positive.
        else if (rb.linearVelocity.x < 0)
            rb.linearVelocity = new Vector2(rb.linearVelocity.x - Mathf.Max(-groundFriction, rb.linearVelocity.x), rb.linearVelocity.y); //Velocity is negative.

        //Apply the velocity to the player
        rb.linearVelocity += new Vector2(scaledAcceleration * Input.GetAxis("Horizontal"), 0);

        //Make my boy jump when we wants
        if(JumpPressed && isGrounded)
        {
            JumpPressed = false;
            rb.AddForce(Vector2.up * jumpForce);
        }
    }
}

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Variables")]
    public float maxSpeed = 100;
    public float jumpForce = 1400;
    public float acceleration = 25;
    public float groundFriction = 5;
    private float JumpBufferTime = 0.15f;
    private float PressedTime = 0;
    private float CoyoteTime = 0.15f;
    private float LastGroundTime = -1f;

    [Header("Ground Check")]
    public Transform groundCheckPoint;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;

    [Header("Wall Jump Stuff")]
    public bool OnWall = false;

    private Rigidbody2D rb;
    private bool isGrounded;

    public bool JumpPressed = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            JumpPressed = true;
            PressedTime = Time.time;
        }
        
    }

    void FixedUpdate()
    {
        WallJumpCheck();
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
        //This allows Coyote Time
        if (isGrounded)
        {
            LastGroundTime = Time.time;
        }
        float scaledAcceleration = acceleration * (1 - Mathf.Abs(rb.linearVelocity.x) / maxSpeed);

        //Apply the friction to the movement
        if (rb.linearVelocity.x > 0)
            rb.linearVelocity = new Vector2(rb.linearVelocity.x - Mathf.Min(groundFriction, rb.linearVelocity.x), rb.linearVelocity.y); //Velocity is positive.
        else if (rb.linearVelocity.x < 0)
            rb.linearVelocity = new Vector2(rb.linearVelocity.x - Mathf.Max(-groundFriction, rb.linearVelocity.x), rb.linearVelocity.y); //Velocity is negative.

        //Apply the velocity to the player
        rb.linearVelocity += new Vector2(scaledAcceleration * Input.GetAxis("Horizontal"), 0);
        
        //Make my boy jump when we wants
        if (JumpPressed && ((Time.time - LastGroundTime <= CoyoteTime) || OnWall))
        {
            //Reset y velocity for quicker movement
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);
            LastGroundTime = -1;
            JumpPressed = false;
            rb.AddForce(Vector2.up * jumpForce);
        }
        //Allows the player to still jump even if they hit the button a little too early, makes movement feel smoother
        if (Time.time - PressedTime >= JumpBufferTime)
        {
            JumpPressed = false;
        }
        if (OnWall)
        {
            float VelocityY = rb.linearVelocity.y;
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, Mathf.Clamp(VelocityY, -2.5f, 100f));
        }
    }

    void WallJumpCheck()
    {
        float Direction = Input.GetAxis("Horizontal");

        RaycastHit2D WallCheck = default;

        //Check for left or right
        if (Direction > 0) WallCheck = Physics2D.Raycast(transform.position, Vector2.right, 1f, groundLayer);
        if (Direction < 0) WallCheck = Physics2D.Raycast(transform.position, Vector2.left, 1f, groundLayer);

        if (WallCheck.collider != null && Direction != 0)
        {
            OnWall = true;
        }
        else OnWall = false;
    }
}

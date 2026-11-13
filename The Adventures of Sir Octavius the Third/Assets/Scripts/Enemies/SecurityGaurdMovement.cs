using UnityEngine;

public class SecurityGaurdMovement : MonoBehaviour
{
    public Transform floorCheckPoint;
    public Transform groundCheckPoint;
    public Transform wallCheckPoint;

    public float speed = 2;
    public float chaseSpeed = 5;
    public float jumpForce = 15;
    public float maxPlayerDist = 7;

    public LayerMask groundLayer;

    public bool playerSpotted = false;

    private GameObject player;
    private bool facingRight = true;
    private Rigidbody2D rb;
    private bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, 0.2f, groundLayer);

        if (playerSpotted == false)
        {
            float moveDirection = facingRight ? 1f : -1f;
            rb.linearVelocity = new Vector2(moveDirection * speed, rb.linearVelocity.y);

            if (Physics2D.OverlapCircle(floorCheckPoint.position, 0.2f, groundLayer) == true || Physics2D.OverlapCircle(wallCheckPoint.position, 0.2f, groundLayer) == true)
            {
                Flip();
            }
        }
        else
        {
            float moveDirection = 0;

            if (player.transform.position.x > transform.position.x){
                moveDirection = 1f;
                if (facingRight == false)
                    Flip();
            }
            else if (player.transform.position.x < transform.position.x){
                moveDirection = -1f;
                if (facingRight == true)
                    Flip();
            }
            
            rb.linearVelocity = new Vector2(moveDirection * chaseSpeed, rb.linearVelocity.y);

            if (player.transform.position.y > transform.position.y){
                if (Physics2D.OverlapCircle(groundCheckPoint.position, 0.2f, groundLayer) == true && isGrounded)
                {
                    //Jump
                    rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                }
            }

            if (Vector3.Distance(transform.position, player.transform.position) >= maxPlayerDist)
            {
                playerSpotted = false;
                player = null;
            }
        }
    }

    void Flip()
    {
        facingRight = !facingRight;

        transform.localScale = new Vector3(
            transform.localScale.x * -1,
            transform.localScale.y,
            transform.localScale.z
        );
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            player = other.gameObject;
            playerSpotted = true;
        }
    }
}

using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [Header("Player/Clone")]
    public bool isClone = false;

    [Header("Components")]
    [SerializeField] private Rigidbody2D playerRigidbody; 
    [SerializeField] private Animator playerAnimator;

    [Header("Movement")]
    [SerializeField] private float jumpForce;
    [SerializeField] private float speed;
    public bool canMove = true;

    [Header("CoyoteTime")]
    [SerializeField] private float coyoteTime = 0.1f;
    private float coyoteTimer;

    private bool isGrounded;
    private float XInput;
    private bool jumpRequested = false;
    private float XVelocity;
    private float YVelocity;

    [Header("Animator Directions")]
    private bool facingRight = true;

    
    

    void Update()
    {
        handleInput();
        handleFlip();
        handleCoyoteTime();
        handleAnimations();
    }

    private void handleInput()
    {
        XInput = Input.GetAxisRaw("Horizontal");
        if (isClone)
        {
            XInput = -XInput;
        }
        if (Input.GetKeyDown(KeyCode.Space) && coyoteTimer > 0f)
        {
            jumpRequested = true;
        }
    }

    private void FixedUpdate()
    {
        handleMovement();
    }

    private void handleMovement()
    {
        if (canMove) {
            XVelocity = XInput * speed;
            YVelocity = playerRigidbody.linearVelocity.y;
            if (jumpRequested)
            {
                YVelocity = jumpForce;
                AudioManager.Instance.PlaySFX(3);
                jumpRequested = false;
            }

            playerRigidbody.linearVelocity = new Vector2(XVelocity, YVelocity);
        }
        
    }

    private void handleAnimations()
    {
        playerAnimator.SetFloat("horizontalMovement",XInput);
        playerAnimator.SetFloat("verticalMovement", playerRigidbody.linearVelocity.y);
        playerAnimator.SetBool("isGrounded", isGrounded);
    }

    private void handleFlip()
    {
        if (playerRigidbody.linearVelocity.x < 0 && facingRight || playerRigidbody.linearVelocity.x > 0 && !facingRight)
        {
            flip();
        }
    }
    private void flip()
    {
        playerAnimator.transform.Rotate(0, 180, 0);
        facingRight = !facingRight;
    }

    private void handleCoyoteTime()
    {
        if (isGrounded)
        {
            coyoteTimer = coyoteTime;
        }
        else
        {
            coyoteTimer -= Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}

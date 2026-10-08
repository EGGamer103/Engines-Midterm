using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb; 
    public float speed = 5f;
    public float jumpSpeed = 5f;
    public float xInput;
    public float yInput;
    public float drag;
    public bool shooting;
    public bool grounded;
    public LayerMask groundLayer;
    public BoxCollider2D groundCheck;
    public BaseFactory baseFactory;


    // Update is called once per frame
    void Update()
    {
        GetInputs();
        IsGrounded();
        Jump();
        Bubble();
    }
    private void FixedUpdate()
    {
        groundMove();
        friction();
    }

    void GetInputs()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
        Input.GetKeyDown(KeyCode.Space);
    }
    void groundMove()
    {
        rb.linearVelocity = new Vector2(xInput * speed, rb.linearVelocity.y);
    }
    void Jump()
    {
        if (grounded && yInput > 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, yInput * jumpSpeed);
        }
    }
    void friction()
    {
        if (grounded && xInput == 0 && yInput == 0)
        {
            rb.linearVelocity *= drag;
        }
    }
    void IsGrounded()
    {
        grounded = Physics2D.OverlapAreaAll(groundCheck.bounds.min, groundCheck.bounds.max, groundLayer).Length > 0;
    }
    void Bubble()
    {
        if (shooting)
        {
            baseFactory.ShootBubbles(transform);
        }
    }
}

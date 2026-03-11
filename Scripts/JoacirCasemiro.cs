using UnityEngine;

public class JoacirCasemiro : MonoBehaviour
{
    public float velocidade;
    private Rigidbody2D rb;
    private bool isGrounded = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();



    }

    // Update is called once per frame
    void Update()
    {
        // esquerda
        if(Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector2(-10f, rb.linearVelocity.y);
        }
        else if(Input.GetKeyUp(KeyCode.A))
        {
            rb.linearVelocity = new Vector2(0f, rb.linearVelocity.y);
        }


        // direita
        if(Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector2(10f, rb.linearVelocity.y);
        }
        else if(Input.GetKeyUp(KeyCode.D))
        {
            rb.linearVelocity = new Vector2(0f, rb.linearVelocity.y);
        }


        // jump
        if(Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 8f);
            isGrounded = false;
        }

        

    }
    
    void OnCollisionEnter2D(Collision2D collision) {
    if (collision.gameObject.CompareTag("Enemy"))
    {
        Destroy(gameObject);
    }

    if (collision.gameObject.CompareTag("Item"))
    {
        Destroy(collision.gameObject);
    }
    
    if (collision.gameObject.CompareTag("Ground"))
    {
        isGrounded = true;
    }
    }
}

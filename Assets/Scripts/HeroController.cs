using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class HeroController : MonoBehaviour
{
    // Haraket için deðerler
    [SerializeField] float movementSpeed = 3f;
    bool facingRight = true;

    Rigidbody2D rb;
    Animator anim;

    // Kamera takibi için
    Vector3 charPos;
    [SerializeField] GameObject camera;

    // Zýplamak için deðerler
    [SerializeField] float jumpForce = 17;
    bool isGrounded;

    void Start()
    {
        // caching
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update() // per frame
    {
        Move();
       
        Run();

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
            anim.SetBool("jump", true);
        }

        charPos = this.transform.position;
    }

    private void LateUpdate()
    {
        camera.transform.position = new Vector3(charPos.x, -0.4f, -10);
    }

    void Move()
    {
        var movement = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;

        // gittiðimiz yöne doðru bakmasý için
        if (movement < 0 && facingRight)
        {
            Flip();
        }

        else if (movement > 0 && !facingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
    }

    void Jump()
    {        
        rb.velocity = Vector2.up * jumpForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Vector3 normal = collision.GetContact(0).normal;
            if (normal == Vector3.up)
            {
                isGrounded = true;
                anim.SetBool("jump", false);
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            anim.SetBool("jump", true);
        }
    }

    void Run()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            movementSpeed = 5;
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            movementSpeed = 3;
        }
        else
        {
            movementSpeed = 0;
        }

        anim.SetFloat("speed", movementSpeed);
    }
}

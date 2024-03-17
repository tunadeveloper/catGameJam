using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class friendlyNPC : MonoBehaviour
{
    public Transform target; // Dostlarýmýzýn kimi takip ettiðini göstermek için
    public float speed = 3f; // Minnoþ dostlarýmýz için takip hýzý
    public float stoppingDistance = 2f; // Herkes üst üste gelememeli dimi :D

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    bool facingRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (target != null)
        {
            // NPC'nin karaktere doðru hareket etmesi için gerekli vektörcüklerim
            Vector2 direction = new Vector2 ((target.position.x - transform.position.x), transform.position.y).normalized;

            // NPC'nin karakterin önünde durmasý için gerekli mesafeyi koruma kalkaný
            if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
            {
                // Minnoþlarýn hareketi
                rb.velocity = direction * speed;
            }
            else
            {
                // Dur iþte :D
                rb.velocity = Vector2.zero;
            }

            if (direction.x < 0 && facingRight)
            {
                Flip();
            }

            else if (direction.x > 0 && !facingRight)
            {
                Flip();
            }
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
    }
}

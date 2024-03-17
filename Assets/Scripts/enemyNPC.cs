using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyNPC : MonoBehaviour
{
    public Transform target; // Takip edilecek kurbanýn (maalesef karakterimiz) transform bilgileri
    public GameObject projectilePrefab; // Fýrlatýlacak nesnenin prefab'ý
    public float speed = 3f; // Takip hýzý , yani evet doðal olarak
    public float fireRate = 1f; // Atýþ hýzý (saniyede kaç kez atýþ yapýlacaðý)

    private Rigidbody2D rb;
    private float nextFireTime;

    bool facingRight = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (target != null)
        {
            // NPC'nin karaktere doðru hareket etmesi için gerekli vektör hesaplamasýný yaptýk
            Vector2 direction = new Vector2((target.position.x - transform.position.x), transform.position.y).normalized;

            // Canilerin hareketini saðlýyor bu
            rb.velocity = direction * speed;

            // OLAMAAAAAZ ATEÞ EDÝYORLAR
            if (Time.time > nextFireTime)
            {
                nextFireTime = Time.time + 1f / fireRate;
                FireProjectile();
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

    void FireProjectile()
    {
        // Lütfen ateþ etme (EDÝCEK)
        if (projectilePrefab != null)
        {
            GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            // HAYIR HAYIR KEDÝM OLMAZZZ
            Vector2 direction = (target.position - transform.position).normalized;
            projectile.GetComponent<Rigidbody2D>().velocity = direction * speed * 2f;
            Destroy(projectile, 3f); // Yani... Evet optimizasyon önemli :)
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // K-kedim... Sanýrým artýk 8 caný var
        if (other.gameObject.CompareTag("Player"))
        {
            //score scriptimde sadece can sayýmý statik þekilde tutuyorum ordan azaltýp sonrasýnda kalpleri açýp kapatýcaðým
            Score.lives--;        
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
    }
}

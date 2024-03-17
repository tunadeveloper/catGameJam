using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyNPC : MonoBehaviour
{
    public Transform target; // Takip edilecek kurban�n (maalesef karakterimiz) transform bilgileri
    public GameObject projectilePrefab; // F�rlat�lacak nesnenin prefab'�
    public float speed = 3f; // Takip h�z� , yani evet do�al olarak
    public float fireRate = 1f; // At�� h�z� (saniyede ka� kez at�� yap�laca��)

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
            // NPC'nin karaktere do�ru hareket etmesi i�in gerekli vekt�r hesaplamas�n� yapt�k
            Vector2 direction = new Vector2((target.position.x - transform.position.x), transform.position.y).normalized;

            // Canilerin hareketini sa�l�yor bu
            rb.velocity = direction * speed;

            // OLAMAAAAAZ ATE� ED�YORLAR
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
        // L�tfen ate� etme (ED�CEK)
        if (projectilePrefab != null)
        {
            GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            // HAYIR HAYIR KED�M OLMAZZZ
            Vector2 direction = (target.position - transform.position).normalized;
            projectile.GetComponent<Rigidbody2D>().velocity = direction * speed * 2f;
            Destroy(projectile, 3f); // Yani... Evet optimizasyon �nemli :)
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // K-kedim... San�r�m art�k 8 can� var
        if (other.gameObject.CompareTag("Player"))
        {
            //score scriptimde sadece can say�m� statik �ekilde tutuyorum ordan azalt�p sonras�nda kalpleri a��p kapat�ca��m
            Score.lives--;        
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
    }
}

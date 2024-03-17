using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel1 : MonoBehaviour
{
    Scene scene;
    public inventory inventory;
    private void Awake()
    {
        //scene imi burda cach ediyoruuuuuz
        scene = SceneManager.GetActiveScene();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && inventory.HasKeyInInventory())
        {
            
            SceneManager.LoadScene(scene.buildIndex + 1);
            inventory.setKey(false);
            //normalde +1 olmadan yaz�nda oldu�umuz sahneyi a�acakt�r o y�zden +1 ekliyoruuuuuz
        }
    }
    public void StartLevel()
    {
        //bu da buton kral�m i�in o7(asker selam�)
        SceneManager.LoadScene(scene.buildIndex + 1);
    }
}

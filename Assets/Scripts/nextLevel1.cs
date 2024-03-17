using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel1 : MonoBehaviour
{
    Scene scene;
    public inventory inventory;
    public AudioSource levelFinished;
    private void Awake()
    {
        //scene imi burda cach ediyoruuuuuz
        scene = SceneManager.GetActiveScene();
        levelFinished = GetComponent<AudioSource>();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && inventory.HasKeyInInventory())
        {
            levelFinished.Play();
            SceneManager.LoadScene(scene.buildIndex + 1);
            inventory.setKey(false);
            //normalde +1 olmadan yazýnda olduðumuz sahneyi açacaktýr o yüzden +1 ekliyoruuuuuz
        }
    }
    public void StartLevel()
    {
        //bu da buton kralým için o7(asker selamý)
        SceneManager.LoadScene(scene.buildIndex + 1);
    }
}

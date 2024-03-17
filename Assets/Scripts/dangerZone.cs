using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dangerZone : MonoBehaviour
{
    //Bu dosya karakterin can kaybedeceði yerlere kooyulacak
    private Scene scene;
    private void Awake()
    {
        //eðer engele takýlýrsan ayný acýlarý bir daha yaþayacaksýn muhuhuhahahah
        scene = SceneManager.GetActiveScene();
        Debug.Log(scene.name);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            //score scriptimde sadece can sayýmý statik þekilde tutuyorum ordan azaltýp sonrasýnda kalpleri açýp kapatýcaðým
            Score.lives--;
            SceneManager.LoadScene(scene.name);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dangerZone : MonoBehaviour
{
    //Bu dosya karakterin can kaybedece�i yerlere kooyulacak
    private Scene scene;
    private void Awake()
    {
        //e�er engele tak�l�rsan ayn� ac�lar� bir daha ya�ayacaks�n muhuhuhahahah
        scene = SceneManager.GetActiveScene();
        Debug.Log(scene.name);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            //score scriptimde sadece can say�m� statik �ekilde tutuyorum ordan azalt�p sonras�nda kalpleri a��p kapat�ca��m
            Score.lives--;
            SceneManager.LoadScene(scene.name);
        }
    }
}

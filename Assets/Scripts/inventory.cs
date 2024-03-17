using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    private bool hasKey = false;
    private bool hasFood = false;
    public AudioSource collectSound;
    public AudioSource foodSound;

    private void Awake()
    {
        collectSound = GetComponent<AudioSource>();
        foodSound = GetComponent<AudioSource>();
    }

    // Anahtar Gel burayaaaaaa 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            collectSound.Play();
            hasKey = true;
            Destroy(collision.gameObject);
            
        }

        if (collision.gameObject.CompareTag("CatFood"))
        {
            foodSound.Play();
            hasFood = true;
            Destroy(collision.gameObject);
        }
    }

    // Anahtar�n envanterde olup olmad���n� kontrol etmek i�in bu metodu olu�turdumm :P
    public bool HasKeyInInventory()
    {
        return hasKey;
    }
    //Kedi mamas�n�n envanterde olup olmad���n� kontrol ediyorum ben (by alttaki kod blo�u)
    public bool HasFoodInInventory()
    {
        return hasFood;
    }
    //bu iki kod blo�u iseeee tabi ki de itemlerimizin durumlar�n� kontrol etmek i�in
    //ilk bak��ta anlad�n dimiii :DD
    public void setFood(bool value)
    {
        hasFood=value;
    }
    public void setKey(bool value)
    {
        hasKey = value;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    private bool hasKey = false;
    private bool hasFood = false;

    // Anahtar Gel burayaaaaaa 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            hasKey = true;
            Destroy(collision.gameObject);
            
        }

        if (collision.gameObject.CompareTag("CatFood"))
        {
            hasFood = true;
            Destroy(collision.gameObject);
        }
    }

    // Anahtarýn envanterde olup olmadýðýný kontrol etmek için bu metodu oluþturdumm :P
    public bool HasKeyInInventory()
    {
        return hasKey;
    }
    //Kedi mamasýnýn envanterde olup olmadýðýný kontrol ediyorum ben (by alttaki kod bloðu)
    public bool HasFoodInInventory()
    {
        return hasFood;
    }
    //bu iki kod bloðu iseeee tabi ki de itemlerimizin durumlarýný kontrol etmek için
    //ilk bakýþta anladýn dimiii :DD
    public void setFood(bool value)
    {
        hasFood=value;
    }
    public void setKey(bool value)
    {
        hasKey = value;
    }
}

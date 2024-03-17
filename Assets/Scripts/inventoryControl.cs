using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventoryControl : MonoBehaviour
{
    //envanter scriptini i�eren gameobject
    public inventory inventory;
    //bu da a��p kapatma yapaca��m�z anahtar resmi
    public Image keyImage;
    //Tahmin edin bu ne i�in bilene 100 puan :D
    public Image foodImage;
    private void Update()
    {
        if (inventory.HasKeyInInventory())
        {
            
            keyImage.enabled = true;
        }
        else
        {
            keyImage.enabled= false;
        }

        if (inventory.HasFoodInInventory())
        {
            foodImage.enabled = true;
        }
        else 
        { 
            foodImage.enabled= false; 
        }
        
    }
}

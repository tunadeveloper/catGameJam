using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feedCats : MonoBehaviour
{
    //bak bu kodda da ayný þekilde inventory scriptini içeren objeyi koyman lazýýýým
    //düþünmeniz lazýýýýýýýým ha bi de ayrýca bu kod collider içeren empty obje içerisine atýlacak rica ederim :DDD
    public inventory inventory;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Payer") && inventory.HasFoodInInventory())
        {
            inventory.setFood(false);
        }
    }
}

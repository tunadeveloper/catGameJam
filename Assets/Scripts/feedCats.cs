using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feedCats : MonoBehaviour
{
    //bak bu kodda da ayn� �ekilde inventory scriptini i�eren objeyi koyman laz����m
    //d���nmeniz laz��������m ha bi de ayr�ca bu kod collider i�eren empty obje i�erisine at�lacak rica ederim :DDD
    public inventory inventory;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Payer") && inventory.HasFoodInInventory())
        {
            inventory.setFood(false);
        }
    }
}

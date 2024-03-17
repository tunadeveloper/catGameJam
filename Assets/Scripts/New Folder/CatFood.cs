using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatFood : MonoBehaviour
{
    [SerializeField] List<GameObject> foodList = new List<GameObject>();
    int i = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CatFood"))
        {
            Destroy(collision.gameObject);
            i++;
        }
    }

    private void Update()
    {
        foodList[i].SetActive(true);
    }
}

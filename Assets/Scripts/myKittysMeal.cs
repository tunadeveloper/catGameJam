using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myKittysMeal : MonoBehaviour
{
    //NOT : Bu script karaktere ekelencek
    //bu Scriptimde de kedimiz normal yemek ve meyveleri toplay�nca ses oynat�lacak ve yiyecekleri toplam�� olacak
    //ve kilo alacaaaaaaaaaaak (oyunda yok bu sadece heyecanland�m)
    AudioSource _audio;
    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NormalFood"))
        {

            _audio.Play();
            Destroy(collision.gameObject);
        }
    }
}

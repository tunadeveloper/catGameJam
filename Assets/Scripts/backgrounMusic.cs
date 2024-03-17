using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgrounMusic : MonoBehaviour
{
    //NOT:bu kod Sahnedeki Background resmine koyulacak!!!
    public AudioClip musicClip; // Müzik dosyasý
    private AudioSource musicSource; // Müzik kaynaðý

    void Start()
    {
        // Müzik kaynaðýný al
        musicSource = GetComponent<AudioSource>();

        // Müziði baþlat
        if (musicClip != null)
        {
            musicSource.clip = musicClip;
            musicSource.loop = true; // Müziði döngüye al, sürekli çalsýn
            musicSource.Play();
        }
        else
        {
            Debug.LogWarning("Müzik dosyasý atanmamýþ!");
        }
    }
}

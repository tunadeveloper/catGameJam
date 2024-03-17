using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgrounMusic : MonoBehaviour
{
    //NOT:bu kod Sahnedeki Background resmine koyulacak!!!
    public AudioClip musicClip; // M�zik dosyas�
    private AudioSource musicSource; // M�zik kayna��

    void Start()
    {
        // M�zik kayna��n� al
        musicSource = GetComponent<AudioSource>();

        // M�zi�i ba�lat
        if (musicClip != null)
        {
            musicSource.clip = musicClip;
            musicSource.loop = true; // M�zi�i d�ng�ye al, s�rekli �als�n
            musicSource.Play();
        }
        else
        {
            Debug.LogWarning("M�zik dosyas� atanmam��!");
        }
    }
}

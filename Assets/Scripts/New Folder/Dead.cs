using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    Animator anim;

    [SerializeField]
    GameObject heart1;
    [SerializeField]
    GameObject heart2;
    [SerializeField]
    GameObject heart3;
    [SerializeField]
    GameObject heart4;
    [SerializeField]
    GameObject heart5;
    [SerializeField]
    GameObject heart6;
    [SerializeField]
    GameObject heart7;
    [SerializeField]
    GameObject heart8;
    [SerializeField]
    GameObject heart9;
    int i = 0;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Dead"))
        {
            anim.SetBool("bornAgain", true);      
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            i++;
        }
    }

    private void Update()
    {
        if(i == 1)
        {
            heart1.SetActive(false);
        }
        if (i == 2)
        {
            heart2.SetActive(false);
        }
        if (i == 3)
        {
            heart3.SetActive(false);
        }
        if (i == 4)
        {
            heart4.SetActive(false);
        }
        if (i == 5)
        {
            heart5.SetActive(false);
        }
        if (i == 6)
        {
            heart6.SetActive(false);
        }
        if (i == 7)
        {
            heart7.SetActive(false);
        }
        if (i == 8)
        {
            heart8.SetActive(false);
        }
        if (i == 9)
        {
            heart9.SetActive(false);
        }
    }
}

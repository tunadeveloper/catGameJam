using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class myKittysHearts : MonoBehaviour
{
    private void Awake()
    {
        switch (Score.lives)
        {
            case 9:
                break;
            case 8:
                gameObject.transform.GetChild(8).gameObject.SetActive(false);
                break;
            case 7:
                gameObject.transform.GetChild(8).gameObject.SetActive(false);
                gameObject.transform.GetChild(7).gameObject.SetActive(false);
                break;
            case 6:
                gameObject.transform.GetChild(8).gameObject.SetActive(false);
                gameObject.transform.GetChild(7).gameObject.SetActive(false);
                gameObject.transform.GetChild(6).gameObject.SetActive(false);
                break;
            case 5:
                gameObject.transform.GetChild(8).gameObject.SetActive(false);
                gameObject.transform.GetChild(7).gameObject.SetActive(false);
                gameObject.transform.GetChild(6).gameObject.SetActive(false);
                gameObject.transform.GetChild(5).gameObject.SetActive(false);
                break;
            case 4:
                gameObject.transform.GetChild(8).gameObject.SetActive(false);
                gameObject.transform.GetChild(7).gameObject.SetActive(false);
                gameObject.transform.GetChild(6).gameObject.SetActive(false);
                gameObject.transform.GetChild(5).gameObject.SetActive(false);
                gameObject.transform.GetChild(4).gameObject.SetActive(false);
                break;
            case 3:
                gameObject.transform.GetChild(8).gameObject.SetActive(false);
                gameObject.transform.GetChild(7).gameObject.SetActive(false);
                gameObject.transform.GetChild(6).gameObject.SetActive(false);
                gameObject.transform.GetChild(5).gameObject.SetActive(false);
                gameObject.transform.GetChild(4).gameObject.SetActive(false);
                gameObject.transform.GetChild(3).gameObject.SetActive(false);
                break;
            case 2:
                gameObject.transform.GetChild(8).gameObject.SetActive(false);
                gameObject.transform.GetChild(7).gameObject.SetActive(false);
                gameObject.transform.GetChild(6).gameObject.SetActive(false);
                gameObject.transform.GetChild(5).gameObject.SetActive(false);
                gameObject.transform.GetChild(4).gameObject.SetActive(false);
                gameObject.transform.GetChild(3).gameObject.SetActive(false);
                gameObject.transform.GetChild(2).gameObject.SetActive(false);//2 nolu child kapatýlýr
                break;
            case 1:
                gameObject.transform.GetChild(8).gameObject.SetActive(false);
                gameObject.transform.GetChild(7).gameObject.SetActive(false);
                gameObject.transform.GetChild(6).gameObject.SetActive(false);
                gameObject.transform.GetChild(5).gameObject.SetActive(false);
                gameObject.transform.GetChild(4).gameObject.SetActive(false);
                gameObject.transform.GetChild(3).gameObject.SetActive(false);
                gameObject.transform.GetChild(2).gameObject.SetActive(false);
                gameObject.transform.GetChild(1).gameObject.SetActive(false);
                break;
            case 0:
                SceneManager.LoadScene(4);
                break;
            default:
                break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public GameObject[] hearts;
    public static int health;
    public GameObject restart;
    public GameObject exit;
    public GameObject wintext;

    private void Start()
    {
        health = hearts.Length;
        hearts[0].gameObject.SetActive(true);
        hearts[1].gameObject.SetActive(true);
        hearts[2].gameObject.SetActive(true);
        Time.timeScale = 1;
    }
    private void Update()
    {
        switch(health)
        {
            case 3:
                hearts[0].gameObject.SetActive(true);
                hearts[1].gameObject.SetActive(true);
                hearts[2].gameObject.SetActive(true);
                break;
            case 2:
                hearts[0].gameObject.SetActive(false);
                hearts[1].gameObject.SetActive(true);
                hearts[2].gameObject.SetActive(true);
                break;
            case 1:
                hearts[0].gameObject.SetActive(false);
                hearts[1].gameObject.SetActive(false);
                hearts[2].gameObject.SetActive(true);
                break;
            case 0:
                hearts[0].gameObject.SetActive(false);
                hearts[1].gameObject.SetActive(false);
                hearts[2].gameObject.SetActive(false);
                Time.timeScale = 0;
                restart.gameObject.SetActive(true);
                exit.gameObject.SetActive(true);
                wintext.gameObject.SetActive(true);
                break;
        }
    }
}

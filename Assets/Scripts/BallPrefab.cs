using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BallPrefab : MonoBehaviour
{
    public GameObject ball1;
    public GameObject ball2;
    private Vector3 ballPrefab1;
    private Vector3 ballPrefab2;
    private float cooldown;
    private float cooldown2;
    public GameObject player1;
    public GameObject player2;
    private void Update()
    {

        ballPrefab2 = player2.transform.position + new Vector3(-2.51f, -0.54f, 0);
        ballPrefab1 = player1.transform.position + new Vector3(2.76f, 1.18f, 0);

        if (Input.GetKeyDown(KeyCode.Space) && cooldown < 0)
        {
            Instantiate(ball2, ballPrefab2, Quaternion.identity);
            cooldown = 1.2f;
        }
        else
        {
            cooldown -= Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Keypad0) && cooldown2 < 0)
        {
            Instantiate(ball1, ballPrefab1, Quaternion.identity);
            cooldown2 = 1.2f;
        }
        else
        {
            cooldown2 -= Time.deltaTime;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Destroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)

    {
        if (other.CompareTag("Ball"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("Player1"))
        {
            Destroy(gameObject);
            HealthManager.health -= 1;
        }
        if (other.CompareTag("Player2"))
        {
            Destroy(gameObject); 
            HealthManager2.health -= 1; 
        }
        if (other.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }

}

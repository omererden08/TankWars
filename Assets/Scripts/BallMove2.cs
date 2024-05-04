using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove2 : MonoBehaviour
{
    private float speed = 4f;
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
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
        if (other.CompareTag("Bomb"))
        {
            Destroy(gameObject);
        }
    }
}

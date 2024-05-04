using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove1 : MonoBehaviour
{
    private float speed = 4f;
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("Player2"))
        {
            Destroy(gameObject);
            HealthManager2.health -= 1;
        }
        if (other.CompareTag("Bomb"))
        {
            Destroy(gameObject);
        }
    }
}

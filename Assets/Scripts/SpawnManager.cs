using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject prefab;
    private void Start()
    {
        InvokeRepeating("Spawn", 3, 2);
    }
    
    Vector2 randomPos()
    {
        float _x = Random.Range(-9.45f, 9.45f);
        float _y = transform.position.y;
        Vector2 spawnPos = new Vector2(_x, _y);
        return spawnPos;
    }
    
    void Spawn() 
    {
        Instantiate(prefab,randomPos(), Quaternion.identity);
    }
}

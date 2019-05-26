using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public bool end;
    public float SpawnRate = 0.3f;
    public GameObject WallPrefab;
    private float nextTimeToSpawn = 0f;
    
    
    void Start()
    {
        end = false;

    }
    void Update()
    {
        if (end == false)
        {
            if (Time.time >= nextTimeToSpawn)
            {
                Instantiate(WallPrefab, Vector3.zero, Quaternion.identity);
                nextTimeToSpawn = Time.time + 1f / SpawnRate;
            }
        }
        

    }

    public void EndGame()
    {
        end = true;

    }

}

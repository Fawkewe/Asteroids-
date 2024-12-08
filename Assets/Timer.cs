using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Timer : MonoBehaviour  
{
    public float timer = 0.0f; //Calculates the seconds

    void Awake()
    {
        FindAnyObjectByType<AsteroidSpawn>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer%2== 0) //spawns every 2 seconds. 
        {
            FindAnyObjectByType<AsteroidSpawn>().AsteroidSpawner();
        }
    }

}

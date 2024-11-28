using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Timer : MonoBehaviour  
{
    public float timer = 0.0f;
    float MaxTime = 16.0f;
    // Start is called before the first frame update
    void Awake()
    {
        FindAnyObjectByType<AsteroidSpawn>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer == 0.0f) 
        {
            FindAnyObjectByType<AsteroidSpawn>().AsteroidSpawner();
        }
        if (timer == 4.0f)
        {
            FindAnyObjectByType<AsteroidSpawn>();
        }
        if (timer ==  8.0f)
        {
            //RedAsteroidSpawn
        }
        if (timer == 12.0f)
        {
            FindAnyObjectByType<AsteroidSpawn>();
        }
        if (timer > MaxTime)
        {
            timer = 0.0f;
        }
    }

}

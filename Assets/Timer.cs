using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Timer : MonoBehaviour  
{
    public float timer = 0.0f; //Calculates the seconds
    // Start is called before the first frame update
    void Awake()
    {
        FindAnyObjectByType<AsteroidSpawn>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer%4== 0) //spawns every 4 seconds. 
        {
            FindAnyObjectByType<AsteroidSpawn>().AsteroidSpawner();
        }
    }

}

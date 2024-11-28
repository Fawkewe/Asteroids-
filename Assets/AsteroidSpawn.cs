using UnityEngine;

public class AsteroidSpawn : MonoBehaviour
{
    public GameObject Asteroid;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AsteroidSpawner()
    { //Up
        for (int i = -4; i < 5; i++)
        {
            Vector3 spawnPosition = new Vector3(i * 2.0f, 4.0f);
            Instantiate(Asteroid, spawnPosition, Quaternion.identity);
        }
        //Down
        for (int i = -4; i < 5; i++)
        {
            Vector3 spawnPosition2 = new Vector3(i * 2.0f, -4.0f);
            Instantiate(Asteroid, spawnPosition2, Quaternion.identity);
        }

        //Right
        for (int i = -4; i < 5; i++)
        {
            Vector3 spawnPosition3 = new Vector3(8.0f, i * 2.0f);
            Instantiate(Asteroid, spawnPosition3, Quaternion.identity);
        }
        //left 
        for (int i = -4; i < 5; i++)
        {
            Vector3 spawnPosition4 = new Vector3(-8.0f, i * 2.0f);
            Instantiate(Asteroid, spawnPosition4, Quaternion.identity);
        }
    }
}


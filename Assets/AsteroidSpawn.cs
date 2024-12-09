using UnityEditor.AnimatedValues;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour
{
    public float timer = 0.0f;
    public GameObject Asteroid;
    [SerializeField] private AudioClip gameSoundClip;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AsteroidSpawner();
        AudioSource.PlayClipAtPoint(gameSoundClip, transform.position, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        //AsteroidSpawner();
    }

    public void AsteroidSpawner()
    {
        //The Asteroids spawner. The Y range is random but the X range is always the same. The last number is the unused Z axis
        timer += Time.deltaTime;
        var positionLeft = new Vector3(-10.0f, Random.Range(-4.0f, 4.0f), 0);
        Instantiate(Asteroid, positionLeft, Quaternion.identity);
        Instantiate(Asteroid, positionLeft, Quaternion.identity);

        var positionRight = new Vector3(10.0f, Random.Range(-4.0f, 4.0f), 0);
        Instantiate(Asteroid, positionRight, Quaternion.identity);
        Instantiate(Asteroid, positionRight, Quaternion.identity);
        if (timer % 4 == 0)
        {
            Instantiate(Asteroid, positionLeft, Quaternion.identity);
            Instantiate(Asteroid, positionLeft, Quaternion.identity);

            Instantiate(Asteroid, positionRight, Quaternion.identity);
            Instantiate(Asteroid, positionRight, Quaternion.identity);
        }
    }
}


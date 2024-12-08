using UnityEditor.AnimatedValues;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour
{
    public float timer = 0.0f;
    public GameObject Asteroid;
    //public GameObject MediumAsteroid;
    //public GameObject SmallAsteroid;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // AsteroidSpawner();
    }

    // Update is called once per frame
    void Update()
    {
        //    timer += Time.deltaTime;
        //    if (timer % 4 == 0) 
        //    {
        //        AsteroidSpawner();
        //    }
    }

    public void AsteroidSpawner()
    { 
       //The Asteroids spawner. The Y range is random but the X range is always the same. The last number is the unused Z axis
       var positionLeft = new Vector3(-10.0f, Random.Range(-4.0f, 4.0f),0);
       Instantiate(Asteroid, positionLeft, Quaternion.identity);

       var positionRight = new Vector3(10.0f, Random.Range(-4.0f,4.0f),0);
       Instantiate(Asteroid, positionRight, Quaternion.identity);
    }
    //public void OrangeAsteroidSpawner()
    //{
    //    var OrangeSpawn = Asteroid.transform.position;
    //    Instantiate(MediumAsteroid,OrangeSpawn,Quaternion.identity);

    //    Instantiate(MediumAsteroid,OrangeSpawn, Quaternion.identity);
    //}

    //public void YellowAsteroidSpawner()
    //{
    //    var YellowSpawn = MediumAsteroid.transform.position;
    //    Instantiate(SmallAsteroid, YellowSpawn,Quaternion.identity);

    //    Instantiate(SmallAsteroid,YellowSpawn,Quaternion.identity);
    //}
}


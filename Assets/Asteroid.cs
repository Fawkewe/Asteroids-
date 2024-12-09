using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] private AudioClip explosionSoundClip;
    public int health;
    public float speed;

    public bool big;
    public bool medium;
    public bool small;

    public GameObject MediumAsteroid;
    public GameObject SmallAsteroid;

    Vector2 direction = Vector2.right;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float RandomX = Random.Range(-1.0f, 1.0f); //numbers
        float RandomY = Random.Range(-1.0f, 1.0f); //numbers
        direction = new Vector2(RandomX, RandomY); //Position

    }
    private void Awake()
    {
        FindAnyObjectByType<AsteroidSpawn>();
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        Vector3 change = direction * speed * dt;
        transform.position += change;

        //movement 
        if (health <= 0 && big)
        {
            Object.Destroy(gameObject);
            //FindAnyObjectByType<AsteroidSpawn>().OrangeAsteroidSpawner();
            var OrangeSpawn = transform.position;
            Instantiate(MediumAsteroid, OrangeSpawn, Quaternion.identity);

            Instantiate(MediumAsteroid, OrangeSpawn, Quaternion.identity);
            AudioSource.PlayClipAtPoint(explosionSoundClip, transform.position, 1f);

        }
        if (health <= 0 && medium)
        {
            Object.Destroy (gameObject);
            var YellowSpawn = transform.position;
            Instantiate(SmallAsteroid, YellowSpawn, Quaternion.identity);

            Instantiate(SmallAsteroid, YellowSpawn, Quaternion.identity);
            AudioSource.PlayClipAtPoint(explosionSoundClip, transform.position, 1f);
            //FindAnyObjectByType<AsteroidSpawn>().YellowAsteroidSpawner();
        } 
        
        if (health <= 0 && small) //The Final function for the Small Asteroid. This should not spilit into anything. 
        {
            Object.Destroy(gameObject);
            //have to get this to create two new Asteroids 
            //Debug.Log("works");
            AudioSource.PlayClipAtPoint(explosionSoundClip, transform.position, 1f);
        }
    }

    public void DamageDealt() 
    {
        int Damage = 1;
        health = health - Damage;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DamageDealt();
    }

    public void PauseAsteroid()
    {
        speed = 0.0f; 
    }
    public void UnPauseAsteroid()
    {
        speed = 5.0f;
    }
}

using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public int health;
    public float speed;

    public bool big;
    public bool medium;
    public bool small;

    Vector2 direction = Vector2.right;
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float RandomX = Random.Range(-1.0f, 1.0f);
        float RandomY = Random.Range(-1.0f, 1.0f);
        direction = new Vector2(RandomX, RandomY);
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
        }
        if (health <= 0 && medium)
        {
            Object.Destroy (gameObject);
        } 
        
        if (health <= 0 && small) //The Final function for the Small Asteroid. This should not spilit into anything. 
        {
            Object.Destroy(gameObject);
            //have to get this to create two new Asteroids 
            //Debug.Log("works");
        }
    }

    public void DamageDealt() 
    {
        int Damage = 1;
        health = health - Damage;
    }
}

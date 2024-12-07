using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public int health;
    public float speed;

    Vector2 direction = Vector2.down;
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        Vector3 change = direction * speed * dt;
        transform.position += change;
        //movement 

        if (health <= 0) //The spilt function 
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

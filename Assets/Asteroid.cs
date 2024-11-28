using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public int health;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            Object.Destroy(gameObject);
            Debug.Log("works");
        }
    }

    public void DamageDealt()
    {
        int Damage = 1;
        health = health - Damage;
    }
}

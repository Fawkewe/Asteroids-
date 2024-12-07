using UnityEngine;

public class Projectile : MonoBehaviour
{
    Vector2 direction = Vector2.up;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 5.0f;
        float dt = Time.deltaTime;
        Vector3 change = direction * speed * dt;
        transform.position += change;
    }
}

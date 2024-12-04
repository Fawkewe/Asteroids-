using UnityEngine;

public class Spaceship : MonoBehaviour
{
    Vector3 Position;
    float Speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        Position = transform.position;
        if (Input.GetKey(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * Speed * dt;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * Speed * dt;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Speed * dt;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Speed * dt;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            //Projectile Function 
        }

        if (transform.position.y > 5 )
        {
            Position.y = -5;
        }
        if (transform.position.y < -5)
        {
            Position.y = 5; 
        }
        if (transform.position.x > 10 )
        {
            Position.x = -10;
        }
        if (transform.position.x < -10)
        {
            Position.x = 10;
        }
    }
}
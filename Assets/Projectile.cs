using UnityEngine;

public class Projectile : MonoBehaviour
{
    float speed = 5.0f;
    Vector2 direction = Vector2.up; //its direction. Has to be a variable so we can edit it later. 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    private void Awake()
    {
        FindAnyObjectByType<Asteroid>();
    }
    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        Vector3 change = direction * speed * dt;
        transform.position += change;

        //all of this is dictating the movement 
    }

    public void Hit()
    {
        Object.Destroy(gameObject);
    }

    public void PauseShot()
    {
        speed = 0.0f;
    }
    public void UnPauseShot()
    {
        speed = 5.0f;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Hit();
        FindAnyObjectByType<Asteroid>().DamageDealt();
    }
}

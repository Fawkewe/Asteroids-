using UnityEngine;

public class Pause : MonoBehaviour
{
    bool isPaused = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && isPaused == false)
        {
            FindAnyObjectByType<Asteroid>().PauseAsteroid();
            FindAnyObjectByType<Projectile>().PauseShot();
            FindAnyObjectByType<Spaceship>().PauseShip();
            isPaused = true;    
            Debug.Log("The Game is paused");
        }
        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == true)
        {
            FindAnyObjectByType<Asteroid>().UnPauseAsteroid();
            FindAnyObjectByType<Projectile>().UnPauseShot();
            FindAnyObjectByType<Spaceship>().UnPauseShip();
            isPaused = false;
            Debug.Log("The Game is Unpaused");
        }
    }
}

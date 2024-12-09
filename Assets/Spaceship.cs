using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Spaceship : MonoBehaviour
{
    Vector3 Position;
    float Speed = 5.0f;
    float RotationSpeed = 100.0f;
    public GameObject Shot;
    private Rigidbody2D Rigidbody;

    bool CanSpawnShot = true;

    Renderer[] Renderers;
    bool iswarpingX = false;
    bool iswarpingY = false;

    private float Horizontal;
    private float Vertical;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Rigidbody = GetComponent<Rigidbody2D>();
       Renderers = GetComponentsInChildren<Renderer>();
    }
    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        Position = transform.position;
        //The controls lol.

        Horizontal = Input.GetAxis("Horizontal");
        //Vertical = Input.GetAxis("Vertical");

        Rigidbody.angularVelocity = -Horizontal * RotationSpeed;
        //Rigidbody.AddForce(transform.up * Vertical * Speed);


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

        if (Input.GetKeyDown(KeyCode.Space) && CanSpawnShot == true)
        {
            var ShotSpawn = transform.position;
            Instantiate(Shot,ShotSpawn,Quaternion.identity);
        }
    }

    void ScreenWarp()
    {
        bool isvisible = CheckRenderers();
        if (isvisible)
        {
           iswarpingX = false;
           iswarpingY = false;
           return;
        }

        if (iswarpingX && iswarpingY)
        {
            return;
        }

        Vector3 newPosition = transform.position;   
        if (newPosition.x < 0 || newPosition.x > 1)
        {
            newPosition.x =  -newPosition.x;
            iswarpingX = true;
        }
        if (newPosition.y < 0 || newPosition.y > 1)
        {
            newPosition.y = -newPosition.y;
            iswarpingY = true;
        }
        transform.position = newPosition;
    }

  bool CheckRenderers()
   {
        foreach(Renderer renderer in Renderers)
        {
            if (renderer.isVisible)
            {
                return true;
            }
        }

        return false;
   }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Object.Destroy(gameObject);
        SceneManager.LoadScene("Game.Over");
    }
    public void PauseShip()
  {
        Speed = 0.0f;
        RotationSpeed = 0.0f;
        CanSpawnShot = false;
  }
  public void UnPauseShip()
    {
        Speed = 5.0f;
        RotationSpeed = 100.0f;
        CanSpawnShot = true;
    }

}


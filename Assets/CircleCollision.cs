using UnityEngine;

public class CircleCollision : MonoBehaviour
{
    public GameObject circle1;
    public GameObject circle2;

    void Start()
    {
        
    }

    private void Awake()
    {
        FindAnyObjectByType<Asteroid>();
    }

    void Update()
    {
        bool collision = CheckCollisionCircles(circle1.transform.position, circle2.transform.position, 0.5f, 0.5f);
        //Color color = collision ? Color.red : Color.green;
        circle1.GetComponent<SpriteRenderer>();//.color = color;
        circle2.GetComponent<SpriteRenderer>();//.color = color;

        // Mtv points FROM 2 TO 1
        Vector2 mtv = Vector3.zero;
        CheckCollisionCircles(circle1.transform.position, circle2.transform.position, 0.5f, 0.5f, out mtv);
        circle1.transform.position += (Vector3)mtv;
    }

    bool CheckCollisionCircles(Vector2 position1, Vector2 position2, float radius1, float radius2)
    {
        // Overlap if the distance between centres is less than the sum of the radii!
        float radiiSum = radius1 + radius2;
        float distance = Vector2.Distance(position1, position2);
        return distance < radiiSum;
    }

    // "Function Overloading" -- functions with the same names but different behaviour;
    // This overload outputs to MTV, allowing us to resolve the collision in addition to detecting it!
    bool CheckCollisionCircles(Vector2 position1, Vector2 position2, float radius1, float radius2, out Vector2 mtv)
    {
        bool collision = CheckCollisionCircles(position1, position2, radius1, radius2);
        if (collision)
        {
            float radiiSum = radius1 + radius2;
            float distance = Vector2.Distance(position1, position2);

            // AB = B - A
            Vector2 direction = (position1 - position2).normalized;
            float depth = radiiSum - distance;

            // MTV resolves 1 from 2
            mtv = direction * depth;

            if (collision == true)
            {
                FindAnyObjectByType<Asteroid>().DamageDealt();
                FindAnyObjectByType<Projectile>().Hit();
                Debug.Log("collision");
            }

        }
        else
        {
            mtv = Vector2.zero;
        }
        return collision;
    }
}

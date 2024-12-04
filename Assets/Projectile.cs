using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject rect;

    //none of this works thus far

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ProjectileVomit()
    {
        Instantiate(rect);
    }
}

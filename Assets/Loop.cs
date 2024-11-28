using UnityEngine;

public class Loop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject rect; 

    void Start()
    {
        //for (int i = 0; i < 10; i++)
        //{
      //      Debug.Log(i);
       // }

        //Instantiate(rect);
        //Instantiate(rect).transform.position = new Vector3(5.0f,0.0f); 

        //Up
        for (int i = -4; i < 5; i++)
        {
            Vector3 spawnPosition = new Vector3(i * 2.0f, 4.0f);
            Instantiate(rect, spawnPosition, Quaternion.identity);
        }
        //Down
        for (int i =-4; i < 5; i++)
        {
            Vector3 spawnPosition2 = new Vector3(i * 2.0f, -4.0f);
            Instantiate (rect, spawnPosition2, Quaternion.identity);
        }

        //Right
        for (int i =-4; i < 5; i++)
        {
            Vector3 spawnPosition3 = new Vector3(8.0f, i * 2.0f);
            Instantiate (rect,spawnPosition3, Quaternion.identity);
        }
        //left 
        for (int i = -4; i < 5; i++)
        {
            Vector3 spawnPosition4 = new Vector3(-8.0f, i * 2.0f);
            Instantiate(rect, spawnPosition4, Quaternion.identity);
        }
    }    

    // Update is called once per frame
    void Update()
    {                                                                              
    }
}

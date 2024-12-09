using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour

{
    [SerializeField] private AudioClip startSoundClip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioSource.PlayClipAtPoint(startSoundClip, transform.position, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}

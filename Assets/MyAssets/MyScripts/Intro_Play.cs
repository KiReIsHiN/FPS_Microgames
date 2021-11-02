using UnityEngine.SceneManagement;
using UnityEngine;

public class Intro_Play : MonoBehaviour
{
    AudioSource _as;
    [SerializeField] AudioClip _ac;

    private void Start()
    {
        _as = GetComponent<AudioSource>();
        _as.PlayOneShot(_ac);
    }

    private void Update()
    {
        if (!_as.isPlaying)
        {
            SceneManager.LoadScene(3);
        }
    }

}

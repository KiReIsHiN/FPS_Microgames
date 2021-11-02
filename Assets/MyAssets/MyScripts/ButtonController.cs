using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private Button _skip;

    private void Start()
    {
        _skip.onClick.AddListener(SkipScene);
    }

    public void SkipScene()
    {
        SceneManager.LoadScene(3);
    }
}

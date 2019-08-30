using UnityEngine;

public class Dndst : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(this);
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}

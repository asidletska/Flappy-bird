using UnityEngine;
using UnityEngine.SceneManagement;

public class backToMenu : MonoBehaviour
{

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        Time.timeScale = 1.0f;
        
    }
    public void OnExitHandler()
    {
        SceneManager.LoadScene(0);
    }
}

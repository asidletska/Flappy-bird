using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    public GameObject panel;
    private int score;

    public void Play()
    {
        Restart();
        Tube[] pipes = FindObjectsOfType<Tube>();
        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject); 
        }
    }
    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }
    public void GameOver()
    {
        panel.SetActive(true);

        Pause();
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    public void Restart()
    {
        player.enabled = true;
    }
}

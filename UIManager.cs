using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text GameOverText;
    [SerializeField] private Text ScoreText;
    [SerializeField] private Text LivesText;

    private int scoreCount = 0;
    private int liveCount = 3;
    void GameOver()
    {
        Time.timeScale = 0;
        GameOverText.gameObject.SetActive(true);
    }

    public void Score()
    {
        scoreCount++;
        ScoreText.text = "Score: " + scoreCount.ToString();
    }

    public void Lives()
    {
        liveCount--;
        LivesText.text = "Lives: " + liveCount.ToString();
        if (liveCount<=0)
        {
            GameOver();
        }
    }
}

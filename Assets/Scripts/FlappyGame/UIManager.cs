using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI restartText;
    public Button backToMain;
    public TextMeshProUGUI bestScoreText;

    private int bestScore = 0;
    private const string BestScoreKey = "BestScore";

    // Start is called before the first frame update
    void Start()
    {
        if (restartText == null) Debug.LogError("restart text is null");

        if (scoreText == null) Debug.LogError("score text is null");

        if (bestScoreText == null) Debug.LogError("bestScore text is null");

        restartText.gameObject.SetActive(false);

        bestScore = PlayerPrefs.GetInt(BestScoreKey, 0);
        BestScore(bestScore);
    }

    public void SetRestart()
    {
        restartText.gameObject.SetActive(true);
    }

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();

        if (score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetInt(BestScoreKey, bestScore);
            PlayerPrefs.Save();
            BestScore(bestScore);
        }
    }

    public void BackToMain()
    {
        backToMain.gameObject.SetActive(true);
    }

    public void BestScore(int bestScore)
    {
        bestScoreText.text = bestScore.ToString();
    }
}

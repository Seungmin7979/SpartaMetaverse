using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CallingResult : MonoBehaviour
{
    public TextMeshProUGUI BestScoreTxt;
    public GameObject ResultPanel;
    public static CallingResult Instance;

    private const string BestScoreKey = "BestScore";

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        ShowResultPanel();
    }

    public void ShowResultPanel()
    {
        int bestScore = PlayerPrefs.GetInt(BestScoreKey, 0);
        BestScoreTxt.text = bestScore.ToString();
        ResultPanel.SetActive(true);
    }
}
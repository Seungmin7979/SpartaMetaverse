using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMiniGame : MonoBehaviour
{
    public string minigameSceneName = "FlappyGameScene";
    public GameObject interactionUI;

    public void StartMinigameScene()
    {
        SceneManager.LoadScene(minigameSceneName);
    }

    public void CancelMinigame()
    {
        interactionUI.SetActive(false);
    }
}

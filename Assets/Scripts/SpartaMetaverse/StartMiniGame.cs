using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMiniGame : MonoBehaviour
{
    public string minigameSceneName = "FlappyGameScene";
    public GameObject interactionUI;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            interactionUI.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (interactionUI != null)
            {
                interactionUI.SetActive(false);
            }
        }
    }

    public void StartMinigameScene()
    {
        SceneManager.LoadScene(minigameSceneName);
    }

    public void CancelMinigame()
    {
        interactionUI.SetActive(false);
    }
}

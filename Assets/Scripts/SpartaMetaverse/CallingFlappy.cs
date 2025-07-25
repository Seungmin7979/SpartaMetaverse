using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CallingFlappy : MonoBehaviour
{
    public GameObject interactionUI; // UI 오브젝트 할당

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
}

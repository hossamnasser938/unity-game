using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    int playerScore = 0;
    public Text playerScoreTextObject;
    public GameObject gameOverUI;

    public void increaseScore(int toBeAddedScore) {
        playerScore += toBeAddedScore;
        playerScoreTextObject.text = playerScore.ToString();
    }

    public void ShowGameOverUI() {
        gameOverUI.SetActive(true);
    }

    public void RestartScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

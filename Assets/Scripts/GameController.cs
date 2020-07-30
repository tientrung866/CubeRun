using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private bool gameHasEnded = false;
    [SerializeField] private float restartDelay = 2f;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Score score = FindObjectOfType<Score>();
            if (score != null) score.DiplayHighScore();
            Invoke("Restart", restartDelay);
        }
    }

    private void Restart()
    {
        SceneManager.LoadScene("demo01");
    }
}

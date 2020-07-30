using System;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    //[SerializeField] GameObject player;
    [SerializeField] Text scoreText;
    [SerializeField] Text highScore;
    private static bool isGameOver;

    float currentScore;

    private void Start()
    {
        isGameOver = false;
        highScore.transform.localScale = Vector3.zero;

        currentScore = 0;
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle")||(transform.position.y < 0f))
        {
            Score.isGameOver = true;
            Debug.Log("Gameover");
        }
    }
    // Update is called once per frame
    void Update()
    {
        // Time.time <=> Time from start of the game
        // => keep updating after reloaded
        // if (!isGameOver) scoreText.text = Time.time.ToString("0");

        if (!isGameOver) {
            currentScore += Time.deltaTime;
            scoreText.text = currentScore.ToString("0");
        } 
    }

    /// <summary>
    /// *Key point*, use PlayerPrefs to store highest score within the key "HighestScore". 
    /// The key-value pair not yet existed, 0 is taken instead.
    /// Current score (the score displayed when game ended) is compared against value within "HighestScore" and get updated
    /// </summary>
    /// <param name="scoreToCheck"></param>
    void SetHighScore()
    {
        int highScore = PlayerPrefs.GetInt("HighestScore", 0);
        int currentScore = int.Parse(scoreText.text);
        if (currentScore > highScore) PlayerPrefs.SetInt("HighestScore", currentScore);
    }

    /// <summary>
    /// First update playerpref data and get that data to the text container and pop it up
    /// </summary>
    /// <param name="scoreToCheck"></param>
    public void DiplayHighScore()
    {
        SetHighScore();
        if (highScore != null)
        {
            highScore.transform.localScale = Vector3.one;
            highScore.text = PlayerPrefs.GetInt("HighestScore", 0).ToString();
        }
    }

    /// <summary>
    /// In case user want to reset saved data, use defined context menu 
    /// </summary>
    [ContextMenu("Reset data")]
    void ResetData()
    {
        PlayerPrefs.DeleteAll();
    }
}

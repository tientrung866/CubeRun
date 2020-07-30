using System;
using UnityEngine;
using UnityEngine.UI;

public class HighestScore : MonoBehaviour
{
    [SerializeField] private Text highestScore;
    [SerializeField] private Text scoreText;
    private int oldScore;
    private int newScore;
//    private int highestScore;
    private int temp;


    // Start is called before the first frame update
    void Start()
    {
        int.TryParse(scoreText.text, out oldScore);
        scoreText.text = PlayerPrefs.GetInt("scoreText", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        int.TryParse(scoreText.text, out newScore);
        if (newScore > oldScore)
        {
            oldScore = newScore;
        }
    }

//    private void toUpdate()
//    {
//        newScore = temp;
//        temp = oldScore;
//        highestScore.text = oldScore.ToString("0");
//    }
}

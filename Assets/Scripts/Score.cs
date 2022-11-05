using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ScoreText;
    int score = 0;
    public int GetCurrentScore()
    {
        ScoreText.text = ("Score = " + score);
        return score;
    }
    private void Start()
    {
        ScoreText.text = ("Score = " + score);
    }
    public void ScoreIncrease(int scoreincrease)
    {
        score += scoreincrease;
        GetCurrentScore();
    }
    public void ScoreDecrease(int scoredecrease)
    {
        score -= scoredecrease;
        GetCurrentScore();
    } 
}

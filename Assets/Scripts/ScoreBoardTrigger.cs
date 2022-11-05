using UnityEngine;
using UnityEngine.UI;

public class ScoreBoardTrigger : MonoBehaviour
{
    public bool atEnter = false;
    public bool inside = false;
    public bool atExit = false;
    public Text ScoreText;
    int score = 0;

    void Start()
    {
        ScoreText.text = ("Score = " + score);
    }

    void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("exit"))
        {
            if (atEnter == true && inside == true)
            {
                atEnter = false;
                inside = false;
                score += 1;
                ScoreText.text = ("Score = " + score);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enter"))
        {
            atEnter = true;
        }
        if (other.CompareTag("inside"))
        {
            inside = true;
        }
    }
}

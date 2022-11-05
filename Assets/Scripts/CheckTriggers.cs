using UnityEngine;
using UnityEngine.UI;

public class CheckTriggers : MonoBehaviour
{
    public bool atEnter = false;
    public bool inside = false;
    public bool atExit = false;
    Score score;

    private void Start()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
    }
    void OnTriggerStay(Collider col)
    {
        if (col.CompareTag("ring"))
        {
            if (atEnter == true && inside == true)
            {
                atEnter = false;
                inside = false;
                score.ScoreIncrease(10);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ring"))
        {
            atEnter = true;
        }
        if (other.CompareTag("ring"))
        {
            inside = true;
        }
    }
}

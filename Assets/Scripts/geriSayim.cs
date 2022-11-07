using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class geriSayim : MonoBehaviour
{
    float toplamZaman = 3;
    public TextMeshProUGUI sayac;
    public GameObject gameover;
    bool zamanlayici;
    void Start()
    {
        zamanlayici = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (zamanlayici && toplamZaman>1)
        {
            toplamZaman -= Time.deltaTime;
            sayac.text = Mathf.FloorToInt(toplamZaman).ToString();
           
        }
        else
        {
            zamanlayici=false;
            GameOver();
            
        }
    }
    void GameOver()
    {
        gameover.SetActive(true);
    }
}

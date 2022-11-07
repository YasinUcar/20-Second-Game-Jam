using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class geriSayim : MonoBehaviour
{
    [SerializeField] float toplamZaman = 21;
    public TextMeshProUGUI sayac;
    public GameObject gameover;
    bool zamanlayici;
    [SerializeField] GameObject obje1;
    [SerializeField] GameObject obje2;
    [SerializeField] GameObject obje3;
    [SerializeField] GameObject obje4;
    void Start()
    {
        zamanlayici = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (zamanlayici && toplamZaman > 1)
        {
            toplamZaman -= Time.deltaTime;
            sayac.text = Mathf.FloorToInt(toplamZaman).ToString();

        }
        else
        {
            zamanlayici = false;

            GameOver();

        }
    }
    void GameOver()
    {
        gameover.SetActive(true);
        obje1.SetActive(false);
        obje2.SetActive(false);
        obje3.SetActive(false);
        obje4.SetActive(false);
    }
}

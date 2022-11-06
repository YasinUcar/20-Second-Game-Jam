using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] float ZamanSayac = 20;
   
    void FixedUpdate()
    {
        ZamanSayac-=Time.deltaTime;
        
    }
}

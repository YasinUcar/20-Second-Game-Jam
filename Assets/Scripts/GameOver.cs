using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class GameOver : MonoBehaviour
{
    [SerializeField] float GameTime = 20;
    [SerializeField] Button RestartButton;
    [SerializeField] Button MainMenuButton;
    
    void FixedUpdate()
    {
        GameTime-=Time.deltaTime;
    }
    
    void Restart()
    {
            SceneManager.LoadScene("Level01"); 
    }
}

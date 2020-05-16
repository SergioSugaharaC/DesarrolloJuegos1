using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour{
    public static GameController instance;
    private int score = 0;
    [SerializeField] private int lives;
    [SerializeField] private Text TxtScore;
    [SerializeField] private Text TxtLives;

    void Start(){
        lives = lives == 0 ? 3 : lives;
        instance = this;
    }

    void Update(){
        TxtScore.text = "Score: " + score.ToString();
        TxtLives.text = lives.ToString() + " Live(s) Left";
    }

    public void SetScore(int scr){ score += scr; }

    public void LossLive(){
        lives -= 1;
        if (lives <= 0){
            SceneManager.LoadScene("GameOver");
        } 
    }
}

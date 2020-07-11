using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour{
    [SerializeField] private Text txtScore;

    void Start(){
        txtScore.text = "Score: " + PlayerPrefs.GetInt("score", 0).ToString();
        StartCoroutine(WaitToMenu());
    }

    IEnumerator WaitToMenu(){
        yield return new WaitForSeconds(3);
        StateController.LoadScene(StateController.State.Menu);
    }
}

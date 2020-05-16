using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonPlayer : MonoBehaviour {
    private Button button;
    private string player;
    void Awake(){
        button = GetComponent<Button>();
        button.onClick.AddListener(()=>GoGame());
        player = gameObject.name[gameObject.name.Length - 1].ToString();
    }

    void GoGame(){
        Debug.Log(player);
        PlayerPrefs.SetString("player", player);
        SceneManager.LoadScene("Game");
    }
}

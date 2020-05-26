using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
    [SerializeField] Button btnRegister;
    [SerializeField] Button btnUsers;
    [SerializeField] Button btnStart;
    [SerializeField] InputField username;
    int key = 0;

    void Start() {
        FirebaseDB.init();
        btnRegister.onClick.AddListener(() => Register());
        btnUsers.onClick.AddListener(() => goUsers());
        btnStart.onClick.AddListener(() => goGame());
        
        if (!PlayerPrefs.HasKey("ID"))
            PlayerPrefs.SetInt("ID", key);
        else 
            key = PlayerPrefs.GetInt("ID");
    }

    void Register() {
        User user = new User(username.text, key.ToString());
        string json = JsonUtility.ToJson(user);
        print(username.text);
        print(json);
        FirebaseDB.reference.Child("users").Child(user.id).SetRawJsonValueAsync(json);
        
        key++;
        PlayerPrefs.SetInt("ID", key);
    }

    void goGame(){ SceneManager.LoadScene("Game"); }
    void goUsers(){ SceneManager.LoadScene("Users"); }
}

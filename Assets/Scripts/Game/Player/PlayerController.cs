using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField] private GameObject uno;
    [SerializeField] private GameObject dos;
    [SerializeField] private GameObject tres;
    [SerializeField] private GameObject cuarto;
    [SerializeField] private GameObject quinto;

    void Awake() {
        string monster = PlayerPrefs.GetString(key:"player");
        GameObject monsterGO = new GameObject();

        if(monster == "1") monsterGO = uno;
        if(monster == "2") monsterGO = dos;
        if(monster == "3") monsterGO = tres;
        if(monster == "4") monsterGO = cuarto;
        if(monster == "5") monsterGO = quinto;
        
        monsterGO = Instantiate(monsterGO, transform.position, Quaternion.identity);
    }

}

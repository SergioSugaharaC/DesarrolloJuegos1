using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    //private GameController controller;

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag != gameObject.tag){
            Destroy(other.gameObject);
            GameController.instance.SetScore(10);
        } else {
            GameController.instance.LossLive();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private BoxCollider2D collider2D;
    private List<string> tags = new List<string>() { "Candy" };

    // Start is called before the first frame update
    void Start(){
        collider2D = GetComponent<BoxCollider2D>();
        collider2D.isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D other){
        GameObject Enemy = other.gameObject;
        if (tags.IndexOf(Enemy.tag) > -1){
            Enemy.SetActive(false);
        }
    }
}

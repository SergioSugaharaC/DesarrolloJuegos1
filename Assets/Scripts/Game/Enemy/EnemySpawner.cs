using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    
    [SerializeField] private List<GameObject> enemies;
    private float elapsed = 0f;
    private float minX, maxX;

    void Awake(){ setMinMax(); }
    
    void setMinMax(){
        Vector3 bounds =
            Camera.main.ScreenToWorldPoint(
                new Vector3(Screen.width, Screen.height, 0));
        minX = -bounds.x;
        maxX =  bounds.x;
    }

    void Update(){
        elapsed+=Time.deltaTime;
        if(elapsed>=2f){
            int index = Random.Range(0, enemies.Count-1);
            Vector3 temp = transform.position;
            temp.x = Random.Range(minX,maxX);
            GameObject enem = Instantiate(enemies[index], temp, Quaternion.identity);
            elapsed = 0f;
        }
    }
}
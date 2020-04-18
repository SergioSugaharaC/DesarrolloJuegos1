using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Variables
    private float timeElapsed = 0f;
    private float Rate = 1.0f;

    // Candy Variables
    [Header("Candy pool")]
    [SerializeField]
    private List<GameObject> Candies = new List<GameObject>();
    private List<GameObject> pool = new List<GameObject>();
    public float startX;


    // Start is called before the first frame update
    void Start(){
        GenerateCandyPool();
    }

    void GenerateCandyPool(){
        for (int i = 0; i < Candies.Count; i++){
            for (int j = 0; j < Candies.Count; j++){
                GameObject Obstacle = Instantiate(Candies[i], new Vector3(startX, -3.5f, 1.0f), Quaternion.identity);
                //Obstacle.transform.localScale = new Vector3(0.5f * scale, 0.5f, 1.0f);
                Obstacle.SetActive(false);
                pool.Add(Obstacle);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= Rate)
        {
            Rate = Random.Range(1.0f, 3.0f);
            timeElapsed = 0f;
            GetFirstDead();
        }
    }

    void GetFirstDead(){
        while (true){
            int index = Random.Range(0, pool.Count - 1);
            if (!pool[index].activeInHierarchy){
                pool[index].SetActive(true);
                pool[index].transform.position = new Vector3(transform.position.x, -3.5f, 0);
                break;
            }
        }
    }

    GameObject getNext(){
        int index = Random.Range(0, Candies.Count - 1);
        return Candies[index];
    }
}

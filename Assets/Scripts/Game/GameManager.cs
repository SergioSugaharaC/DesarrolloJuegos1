using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject platform;
    private float minX = -2.5f, maxX = 2.5f, minY = -2.5f, maxY = 2.5f;

    private bool lerpCamera;
    private float lerpTime = 1.5f;
    private float leapX;

    void Awake(){
        MakeInstance();
        CreateInitialPlatform();
    }

    void MakeInstance(){
        if(instance == null) instance = this;
    }

    void CreateInitialPlatform(){
        Vector3 temp;
        temp =new Vector3(Random.Range(minX,maxX + 1.2f), Random.Range(minY,maxY),0);
        Instantiate(platform, temp, Quaternion.identity);

        temp.y += 2f;
        Instantiate(player, temp, Quaternion.identity);

        temp = new Vector3(Random.Range(minX,maxX + 1.2f), Random.Range(minY,maxY),0);
        Instantiate(platform, temp, Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

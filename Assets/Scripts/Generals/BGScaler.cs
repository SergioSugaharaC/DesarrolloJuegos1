﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScaler : MonoBehaviour{
    private float height;
    private float width;
    
    void Awake(){
        //DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start(){
        height = Camera.main.orthographicSize * 2f;
        width = height * Screen.width / Screen.height;
        if (gameObject.name == "Background")
            transform.localScale = new Vector3(width, height, 1f);
        else
            transform.localScale = new Vector3(width, 5f, 1f);
    }
}

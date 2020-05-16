using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    //[HideInInspector]
    private Rigidbody2D body;
    [SerializeField] private float speed;

    void Awake(){
        body = GetComponent<Rigidbody2D>();
        speed = speed == 0 ? 5 : speed;
    }

    void FixedUpdate(){
        if(Input.GetKey(KeyCode.A))
            body.velocity = new Vector2(-speed,0);
        else 
        if(Input.GetKey(KeyCode.D))
            body.velocity = new Vector2( speed,0);
        else 
            body.velocity = new Vector2(0,0);
        
    }

}
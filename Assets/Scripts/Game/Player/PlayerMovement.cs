using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 8.0f;
    private Rigidbody2D body;

    void Awake(){
        body = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate(){
        HeroFly();
    }

    void HeroFly(){
        float vertical = Input.GetAxisRaw("Vertical");

        if (vertical > 0){
            body.velocity = new Vector2(0.0f, speed);
        } else
        if (vertical < 0){
            body.velocity = new Vector2(0.0f, -speed);
        } else {
            body.velocity = Vector2.zero;
        }
    }
}

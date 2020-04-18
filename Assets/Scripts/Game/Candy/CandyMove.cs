using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyMove : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start(){
        body = GetComponent<Rigidbody2D>();
        speed = speed == 0 ? -4 : -speed;
    }

    // Update is called once per frame
    void Update(){
        body.velocity = new Vector2(speed, 0.0f);
    }
}

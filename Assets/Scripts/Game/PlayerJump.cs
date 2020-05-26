using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerJump : MonoBehaviour
{
    public static PlayerJump instance;
    private Rigidbody2D body;
    private Animator animator;

    private Slider PowerBar;
    private float powerBarTreshold = 10f;
    private float powerBarValue = 0f;

    [SerializeField] private float forceX, forceY;
    [SerializeField] private float maxForceX = 6.5f, maxForceY = 13.5f;
    private float tresholdX = 7f;
    private float tresholdY = 14f;
    private bool setPower, didJump;

    void Awake(){
        MakeInstance();
        Init();
    }

    void MakeInstance(){
        if(instance == null) instance = this;
    }

    void Init(){
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        PowerBar = GameObject.Find("PowerBar").GetComponent<Slider>();

        PowerBar.minValue = powerBarValue;
        PowerBar.maxValue = powerBarTreshold;
        PowerBar.value = powerBarValue;
    }

    void Update(){
        SetPower();
    }

    void SetPower(){
        if(setPower){
            forceX += tresholdX * Time.deltaTime;
            forceY += tresholdY * Time.deltaTime;
            if(forceX > 6.5f) forceX = maxForceX;
            if(forceY > 6.5f) forceY = maxForceY;
            
            powerBarValue += powerBarTreshold * Time.deltaTime;
            PowerBar.value = powerBarValue;
        
            /// call Powerbar
        }
    }

    public void givePower(bool power){
        setPower = power;
        if(!setPower) Jump();
    }

    void Jump(){
        body.velocity = new Vector2(forceX, forceY);
        forceX = forceY = 0;
        didJump = true;
        animator.SetBool("Jump", didJump);
        powerBarValue = 0;
        PowerBar.value = powerBarValue;
        /// reduce PowerBar
    }

    void OnTriggerEnter2D(Collider2D other){
        if(didJump){
            didJump = false;
            animator.SetBool("Jump", didJump);
            if(other.gameObject.tag == "Platform"){

            }
        }
    }
}

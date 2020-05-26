using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler{
    public void OnPointerDown(PointerEventData eventData){
        if(PlayerJump.instance != null)
            PlayerJump.instance.givePower(true);
        print("onPointerDown");
    }

    public void OnPointerUp(PointerEventData eventData){
        if(PlayerJump.instance != null)
            PlayerJump.instance.givePower(false);
        print("onPointerUp");
    }
}

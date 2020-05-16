using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScaler : MonoBehaviour{
    void Start(){
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        Vector3 temp = transform.localScale;
        float width = sr.sprite.bounds.size.x;

        float scrH = Camera.main.orthographicSize * 2f;
        float scrW = scrH / Screen.height * Screen.width;

        temp.x = scrW / width;
        transform.localScale = temp;
    }
}

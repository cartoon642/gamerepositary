using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public Vector3 movePaddle;
    
    void Update () {
        float mousepos = Input.mousePosition.x;
        movePaddle = new Vector3(mousepos/Screen.width*16-8, gameObject.transform.position.y, gameObject.transform.position.z);
        movePaddle.x = Mathf.Clamp(mousepos / Screen.width * 16 - 8, -7.20f, 7.20f);
        gameObject.transform.position = movePaddle;
        


    }
}

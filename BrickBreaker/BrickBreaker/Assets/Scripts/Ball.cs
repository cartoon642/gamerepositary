using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    int count = 0;
    public Paddle paddle;
    Vector3 ballpaddledifference;
    
    
	void Start () {
        ballpaddledifference = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (count == 0)
        {
            if (Input.GetMouseButton(0))
            {

                count++;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
            }
        }
        //    float mousepos = Input.mousePosition.x;
        //    Vector3 moveball = new Vector3(mousepos / Screen.width * 16 - 8, gameObject.transform.position.y, gameObject.transform.position.z);
        //    gameObject.transform.position = moveball;
        if (count == 0)
        {
            this.transform.position = paddle.transform.position + ballpaddledifference;
            
        }
    }
}

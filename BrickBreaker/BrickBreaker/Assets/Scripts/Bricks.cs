using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour {

    int timeshit;
	void Start () {
        timeshit = 0;

    }
	
	// Update is called once per frame
	void Update () {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        timeshit++;
        print(gameObject.name + " : " + timeshit);
        if (timeshit == 3)
        {
            Destroy(this.gameObject);
        }
    }
}

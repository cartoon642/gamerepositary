using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour {
    LevelManager levelmanager = new LevelManager();
    win win;
    public int maxhits;
    int timeshit;
    int bricksdestroyed;
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
        if (timeshit >= maxhits)
        {
            bricksdestroyed++;
            Destroy(this.gameObject);
        }
        if (bricksdestroyed == win.totalbricks) ;
        {
            levelmanager.loadlevel("Win");
        }

    }
}

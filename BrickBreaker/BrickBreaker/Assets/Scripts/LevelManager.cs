﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    public void loadlevel(string x)
    {
        SceneManager.LoadScene(x);
        
    }
    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}

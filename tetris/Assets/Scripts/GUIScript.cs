using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIScript : MonoBehaviour {



    public static int currentScore = 0;
    public static int currentLevel = 1;
    public GUISkin mySkin;


    public void OnGUI()
    {
        GUI.skin = mySkin;


        GUI.Label(new Rect(20, 10, 200,25), "Score" );
        GUI.Label(new Rect(20, 40, 200, 25), currentScore.ToString());


        GUI.Label(new Rect(20, 70, 200, 25), "Level");
        GUI.Label(new Rect(20, 100, 200, 25), currentLevel.ToString());





    }




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

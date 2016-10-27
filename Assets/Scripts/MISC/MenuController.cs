using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MenuController : MonoBehaviour {

    string name = "";
    string score = "";
    List<Scores> highscore;

	// Use this for initialization
	void Start () {
        //EventManager._instance._buttonClick += ButtonClicked;

        highscore = new List<Scores>();
	
	}
    void ButtonClicked(GameObject _obj)
    {
        print("Clicked button:" + _obj.name);
    }

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect((Screen.width / 2), (Screen.height / 2), 100,100));
        GUILayout.Label("Name:");
        name = GUILayout.TextField(name);
        GUILayout.EndArea();

        GUILayout.BeginHorizontal();
        GUILayout.Label("Score:");
        score = GUILayout.TextField(score);
        GUILayout.EndHorizontal();

        if (GUILayout.Button("Add Score"))
        {
            HighScoreManager._instance.SaveHighScore(name, System.Int32.Parse(score));
            highscore = HighScoreManager._instance.GetHighScore();
        }
        if(GUILayout.Button("Get LeaderBoard"))
        {
            highscore = HighScoreManager._instance.GetHighScore();
        }
        if(GUILayout.Button("Clear LeaderBoard"))
        {
            HighScoreManager._instance.ClearLeaderBoard();
        }

        GUILayout.Space(25);

        foreach(Scores _score in highscore)
        {
            GUILayout.BeginHorizontal();
            GUILayout.Label(_score.name, GUILayout.Width(Screen.width / 2));
            GUILayout.Label("" + _score.score, GUILayout.Width(Screen.width / 2));
            GUILayout.EndHorizontal();
        }
    }
}

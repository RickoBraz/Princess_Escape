using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.UI;

public class gameOver : MonoBehaviour {
    string name = "";
    int score = 0;
    List<Scores> highscore;
    public Font Myfont;
    public bool ins;

    // Use this for initialization
    void Start () {
        ins = false;
        gameObject.SetActive(false);
        highscore = new List<Scores>();

    }
    void OnGUI()
    {
        GUI.skin.font = Myfont;
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("<size=28> Get LeaderBoard </size>"))
        {
            highscore = HighScoreManager._instance.GetHighScore();
        }
        if (GUILayout.Button("<size=28>Restart</size>"))
        {
            PlayerPrefs.SetInt("highscore", 0);
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (GUILayout.Button("<size=28>Quit</size>"))
        {
            PlayerPrefs.SetInt("highscore", 0);
            Application.Quit();
        }
        /*if (GUILayout.Button("Clear LeaderBoard"))
        {
            HighScoreManager._instance.ClearLeaderBoard();
        }*/
        GUILayout.EndHorizontal();

        GUILayout.Space(25);


        GUILayout.Label("<color=white><size=35>             HIGH SCORES</size></color>");
        foreach (Scores _score in highscore)
        {         
            GUILayout.BeginHorizontal();
            GUILayout.Label(_score.name, GUILayout.Width(Screen.width / 2));
            GUILayout.Label("" + _score.score, GUILayout.Width(Screen.width / 2));

            //GUILayout.Label("<color=green><size=35>" + _score.name + "   .........................................    </size></color>" + "<color=white><size=35>" + _score.score + "</size></color>");
            GUILayout.EndHorizontal();
        }

        if (ins == true)
        {
            GUI.enabled = false;
        }
        GUILayout.BeginHorizontal();
            GUILayout.Label("Name:");
            name = GUILayout.TextField(name);
            score = PlayerPrefs.GetInt("highscore");
            GUILayout.Label("<color=yellow><size=24>YOUR SCORE: </size></color>" + "<color=white><size=24>" + score + "</size></color>");
        if (GUILayout.Button("Add Score"))
            {
                HighScoreManager._instance.SaveHighScore(name, score);
                highscore = HighScoreManager._instance.GetHighScore();
                ins = true;
            }
            GUILayout.EndHorizontal();
            
    }

}

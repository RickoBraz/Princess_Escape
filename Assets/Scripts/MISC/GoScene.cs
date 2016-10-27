using UnityEngine;
using System.Collections;

public class GoScene : MonoBehaviour {

    public void ChangeScene(string scene){
        Application.LoadLevel(scene);
    }

    public void Restart(){
        PlayerPrefs.SetInt("highscore", 0);
        Application.LoadLevel(Application.loadedLevel);
    }

    public void Fechar() {
        PlayerPrefs.SetInt("highscore", 0);
        Application.Quit();
    }
}

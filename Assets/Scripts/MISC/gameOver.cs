using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour {


	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
    }

    void Update(){
        if (Input.GetKey(KeyCode.R)){
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    // Update is called once per frame

}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class collPlayer : MonoBehaviour
{
    public static collPlayer instance;

    [Header("Questões da vida")]
    [SerializeField]private int life = 1, contaPisca;
    public Text Tlife;
    public GameObject gameover;

    [Header("Proxima fase")]
    public string scene;

    [Header("local de particulas")]
    public GameObject particulas;

    void Start() {
        if (instance == null) instance = this;
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Plataforma")  Bullet.instance.Recarregar();
        if (other.gameObject.tag == "end")
        {
            GetComponent<Gemas>().SaveScore();
            Application.LoadLevel(scene);
        }
        if (other.gameObject.tag == "Respawn") afectLife();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Gemas") {
            Instantiate(particulas, (gameObject.transform.position), Quaternion.identity);

            Gemas.instance.Pontuaçao();
            Destroy(other.gameObject);
        }
    }

    public void afectLife() {
        if (life < 1) {
            PlayerPrefs.SetInt("highscore", 0);
            gameover.SetActive(true);
            Time.timeScale = 0f;

        }
        else {
            //GetComponent<RandomPrincess>().Start();
            life -= 1;
            Tlife.text = (Mathf.RoundToInt(life)).ToString();
        }
    }

    public void Mlife() {
        life += 1;
        Tlife.text = (Mathf.RoundToInt(life)).ToString() + " Princess";
    }
}

using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public static Bullet instance;
    [SerializeField]
    private GameObject bullet, player;
    public int balas = 5;
    private Vector2 origem;
    public KeyCode disparo;
    private Rigidbody2D player_rb;

    [Header("local de som")]
    public GameObject particulas;

    [Header("local de hud")]
    public GameObject bala1,bala2,bala3,bala4,bala5;
    // Update is called once per frame
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Update()
    {
        hudUpdate();
        if (Input.GetKeyUp(disparo) && balas > 0 && Time.timeScale == 1)
        {
            Instantiate(particulas, (gameObject.transform.position), Quaternion.identity);
            origem = new Vector2(player.transform.position.x, player.transform.position.y - 2f);
            Instantiate(bullet, origem, Quaternion.identity);
            Movimento.instance.RecuoBala();
            balas -= 1;
        }
    }

    public void hudUpdate() {
        if (balas > 4){
            bala5.SetActive(true);
        } else {
            bala5.SetActive(false);
        }
        if (balas > 3){
            bala4.SetActive(true);
        } else {
            bala4.SetActive(false);
        } if (balas > 2){
            bala3.SetActive(true);
        } else {
            bala3.SetActive(false);
        }
        if (balas > 1){
            bala2.SetActive(true);
        } else {
            bala2.SetActive(false);
        }if (balas > 0){
            bala1.SetActive(true);
        } else {
            bala1.SetActive(false);
        }
    }

    public void Recarregar() { balas = 5; }
}

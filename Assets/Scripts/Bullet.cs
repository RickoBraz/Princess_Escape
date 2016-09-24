using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour 
{
    public static Bullet instance;
    [SerializeField] private GameObject bullet, player;
    public int balas = 5;
	private Vector2 origem;
	public KeyCode disparo;
    private Rigidbody2D player_rb;

    // Update is called once per frame
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Update () {
		if (Input.GetKeyUp (disparo) && balas > 0) 
		{
			origem = new Vector2 (player.transform.position.x, player.transform.position.y  - 2f);
			Instantiate (bullet, origem, Quaternion.identity);
            Movimento.instance.RecuoBala();
            balas -= 1;
        }
	}

    public void Recarregar(){ balas = 5; }
}

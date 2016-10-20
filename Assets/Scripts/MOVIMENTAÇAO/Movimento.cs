using UnityEngine;
using System.Collections;

public class Movimento : MonoBehaviour
{
    public static Movimento instance;

    [SerializeField] private KeyCode right, left;
    [SerializeField] private float velright, velleft, veldown = -15f;
    private float o_velright, o_velleft;
    [SerializeField] private int count, time = 10;
    [SerializeField] private GameObject player;
    private Rigidbody2D player_rb;
    public string scene;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        o_velright = velright;
        count = 0;
        StartCoroutine(leftdown());
        StartCoroutine(getRB());
        o_velleft = velleft;

    }

    IEnumerator leftdown()
    {
        velleft = velleft * -1;
        yield return new WaitForSeconds(0);
        print("valores corrigidos");
    }

    IEnumerator getRB()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player_rb = player.GetComponent<Rigidbody2D>();
        yield return new WaitForSeconds(3);
        print("player is connected");
    }

    void Update()
    {

        if (Input.GetKey(right))
        {
            count = 1;
        }
        else if (Input.GetKey(left))
        {
            count = 2;
        }
        else
        {
            if (time == 0)
            {
                count = 0;
            }
        }
    }
    void FixedUpdate()
    {
        if (count == 1)
        {
            if (time > 0) time -= 1;
            else veldown = -15;
            player_rb.velocity = new Vector2(velright, veldown);
        }
        else if (count == 2)
        {
            if (time > 0) time -= 1;
            else veldown = -15;
            player_rb.velocity = new Vector2(velleft, veldown);
        }
        else if (count == 3)
        {
            if (time > 0)
            {
                time -= 1;
                player_rb.velocity = new Vector2(player_rb.velocity.x, veldown = 15);
            }
        }
        else
        {

        player_rb.velocity = new Vector2(0f, veldown = -15);
        }
    }
    public void RecuoBala()
    {
        time = 10;
        count = 3;
    }

    

}

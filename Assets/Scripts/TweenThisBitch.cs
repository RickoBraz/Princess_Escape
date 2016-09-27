using UnityEngine;
using System.Collections;

public class TweenThisBitch : MonoBehaviour
{
    public enum Direction { Left, Right };
    public Direction direction = Direction.Left;

    public Transform startMarker;
    public Transform endMarker;

    public float distCovered;
    public float fracJourney;

    public float speed = 1.0F;
    private float startTime;
    private float journeyLength;
    

    // Use this for initialization
    void Start()
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }

    void Update()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);
        /*switch(direction)
        {
            case Direction.Left:
                //Left
                transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);
                if (transform.position == endMarker.position)
                {
                    direction = Direction.Right;
                }
                break;
            case Direction.Right:
                //Right
                transform.position = Vector3.Lerp(endMarker.position, startMarker.position, fracJourney);
                if (transform.position == startMarker.position)
                {
                    direction = Direction.Left;
                }
                break;
        }*/
    }

       void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    float speed;
    public float Speed { get; set; }

    private const float MAXSPEED = 20f;
    Vector2 direction;
    public Vector2 Direction { get; set; }

    public float Radius { get; } = .50f;

    private float xRand;
    private float yRand;


    void Start()
    {
        xRand = (UnityEngine.Random.Range(0, 2) * 1.87f) - 1;  // -1 or 1
        yRand = UnityEngine.Random.value * 1.87f - 1; // random float between -1.0 and 1.0
        direction = new Vector2(xRand, yRand);
        
    }

    void Update()
    {
        if (speed >= MAXSPEED)
        {
            speed = MAXSPEED;
        }
        transform.Translate(direction * speed * Time.deltaTime);
        yCollision();
        xCollision();
    }


    private void yCollision()
    {
        if ((transform.position.y < GameManager.bottomLeft.y + Radius) && direction.y < 0)
        {
            direction.y = -direction.y;
            direction.x = (UnityEngine.Random.value * 1.87f) - 1;
            speed = UnityEngine.Random.Range(10, MAXSPEED);
        }
        if ((transform.position.y > GameManager.topRight.y - Radius) && direction.y > 0)
        {
            direction.y = -direction.y;
            direction.x = (UnityEngine.Random.value * 1.87f) - 1;
            speed = UnityEngine.Random.Range(10, MAXSPEED);
        }
    }
    private void xCollision()
    {
        if ((transform.position.x < GameManager.bottomLeft.x + Radius) && direction.x < 0)
        {
            direction.x = -direction.x;
            direction.y = (UnityEngine.Random.value * 1.87f) - 1;
            speed = UnityEngine.Random.Range(10, MAXSPEED);
        }
        if ((transform.position.x > GameManager.topRight.x - Radius) && direction.x > 0)
        {
            direction.x = -direction.x;
            direction.y = (UnityEngine.Random.value * 1.87f)- 1;
            speed = UnityEngine.Random.Range(10, MAXSPEED);
        }
    }

   

    public float GetSpeed()
    {
        return speed;
    }


    public Vector2 GetDirection()
    {
        return direction;
    }

}

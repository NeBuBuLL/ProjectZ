using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    float score = 0;
    public float Score {get; set;}

    private Text scoreText;
    public Ball ball = new Ball();

    void Start()
    {
        scoreText = GetComponent<Text>();
    }
    void Update()
    {
        ball.Speed = ball.GetSpeed();
        ball.Direction = ball.GetDirection();
        CheckForTouch();
        scoreText.text = "" + string.Format("{0:0}", score);
        ScoreData.ScorePlayer = score;
    }

    void CheckForTouch()
    {
        foreach (Touch touch in Input.touches)
        { 
            if (touch.phase == TouchPhase.Began)
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint((touch.position)), Vector2.zero);

                if (hit.collider != null && hit.collider.transform.gameObject.name == "Ball")
                {
                    score += ball.Speed * Mathf.Abs(ball.Direction.x) * Mathf.Abs(ball.Direction.y) * 100;
                }

            }
        }
    }
}

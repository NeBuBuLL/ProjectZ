using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{

    private float scoreTotal;
    private Text scoreText;


    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreTotal = ScoreData.ScorePlayer;
        scoreText.text = "" + string.Format("{0:0}", scoreTotal);
    }

}

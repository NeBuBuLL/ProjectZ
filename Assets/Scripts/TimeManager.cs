using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{

    public float startingTime = 30.0f;
    private Text theText;
    
    void Start()
    {
        theText = GetComponent<Text>();
    }


    void Update()
    {
        startingTime -= Time.deltaTime;
        theText.text = "" + string.Format("{0:0.0}", startingTime);

        if (startingTime <= 0)
        {
            SceneManager.LoadScene("Score");
        }
    }

}

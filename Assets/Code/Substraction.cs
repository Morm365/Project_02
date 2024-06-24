using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Substraction : MonoBehaviour
{



    private Text score;

    private int scoreAmount;

    void Start()
    {

        scoreAmount = 100;
        score = GetComponent<Text>();



    }


       private void Update()
        {

        score.text = scoreAmount.ToString();


        }

    public void SubstractScore()

    {
        scoreAmount -= 1; //subtracting one from the total value.


    }


}

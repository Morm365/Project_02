using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Addition : MonoBehaviour
{
    [SerializeField] InputField field1, field2;
    [SerializeField] Text textView;


    public void Add()                      //adding numbers from input fields
    {
        int number1 = int.Parse(field1.text);          //Convert text to numbers
        int number2 = int.Parse(field2.text);
        int Ansver = number1 + number2;
        textView.text = "Ansver " + Ansver;           //Text update

    }



  
}

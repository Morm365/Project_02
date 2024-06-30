using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Normalisation : MonoBehaviour
{

    public Transform point1;


    public Transform target;

    public Text text1;

    public Text text2;


    void Update()
    {



        point1.position = Vector3.Normalize(target.position) * 40;

        text1.text = target.position + "and" + point1.position;

        text2.text = point1.position.x + "-" + point1.position.y + "-" + point1.position.z;






    }
}

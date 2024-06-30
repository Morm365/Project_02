using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetaryCenter : MonoBehaviour
{


    [SerializeField]   //Link to the object around which the rotation will take place

    Transform center;

    [SerializeField]

    float radius = 5f, angleSpeed = 1f;

    float positionX, positionY, angle = 0f;

    void Start()
    {
        
    }

    
    void Update()
    {
        positionX = center.position.x + Mathf.Cos(angle) * radius;                //Calculating a new position
        positionY = center.position.y + Mathf.Sin(angle) * radius;

        transform.position = new Vector3(positionX, positionY);

        angle = angle + Time.deltaTime * angleSpeed;            //Angle increase

        if (angle >= 360f)   //Looping in a circle
        {
            angle = 0f;
        }






    }
}

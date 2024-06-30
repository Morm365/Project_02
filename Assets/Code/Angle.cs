using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class VectorRotation : MonoBehaviour
{
      
   // float angle = speed * Time.deltaTime;
       
     
    public float speed = 45f; 
     

    void Update()
    {
        
      float angle = speed * Time.deltaTime; //angle per frame
         
 
               Quaternion rotation = Quaternion.Euler(0, angle, 0);

       transform.rotation = rotation * transform.rotation;

    }
}

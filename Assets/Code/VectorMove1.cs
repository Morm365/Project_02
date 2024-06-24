using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMove1 : MonoBehaviour
{
    public int speed;
    void Start()
    {
        
    }

    
    void Update()
    {
        //transform.Translate(Vector3.up * 6.0f * Time.deltaTime); // Object moving at speed 6.0f
        transform.Translate(Vector3.up * speed * Time.deltaTime); //This option can be changed directly from the inspector.
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMove3 : MonoBehaviour
{
    public int speed;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(0, 0, 5 * speed * Time.deltaTime); //Z axis movement
    }
}

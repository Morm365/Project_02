using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingColour : MonoBehaviour
{
    MeshRenderer meshRenderer;


    float timer = 0;

    float r = 0;

    float g = 0;

    float b = 0;





    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

   


    void Update()
    {
        timer += Time.deltaTime;


        if (timer > 0.05f)
        {

            r = Random.Range(0.0f, 5.0f);

           // g = Random.Range(0.0f, 1.0f);

           b = Random.Range(0.0f, 1.0f);

            timer = 0;

        }


        meshRenderer.material.color = Color.Lerp(meshRenderer.material.color, new Color(r, g, b), Time.deltaTime);



    }
}

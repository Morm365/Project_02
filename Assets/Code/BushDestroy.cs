using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushDestroy : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.tag == "Player")
        {

            Destroy(other.gameObject);

            

        }

    }


}

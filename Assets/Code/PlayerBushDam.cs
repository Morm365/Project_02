using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushDamag : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {



      

        if (other.gameObject.tag == "Bush")
        {

            Destroy(other.gameObject);



        }

    }



}

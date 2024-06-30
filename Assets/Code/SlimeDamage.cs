using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeDamage : MonoBehaviour
{


    private void SlimeDam(Collider other)
    {





        if (other.gameObject.tag == "Slime")
        {

            Destroy(other.gameObject);



        }

    }


}

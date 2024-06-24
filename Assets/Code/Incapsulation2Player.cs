using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Incapsulation2Player : MonoBehaviour
{
    
    private int damage = 5;

   
   


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Slime")
        {

            SlimeHealth slimeHealth = other.GetComponent<SlimeHealth>();
            if (slimeHealth != null)
            {
                slimeHealth.ReceiveDamage(damage);
            }

           

        }

    }

    




}

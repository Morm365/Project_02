using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeHealth : MonoBehaviour
{
    
   [SerializeField] private int health = 20;

    private bool protection;


       

    
   

   public void ReceiveDamage(int damage)
   {
        if (damage < 0 || protection) return; //Protection from receiving negative damage so that health does not increase.

        health -= damage;
        protection = true; //Prevents taking damage after taking damage.

        Invoke(nameof(turnOffProtection), 1f);//Damage is ignored for one second. Turn on the turnOffProtection method after 1 second
   }



    private void turnOffProtection()
    {
        protection = false;
    }






}

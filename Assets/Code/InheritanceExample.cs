using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class Slime : MonoBehaviour
    {

        [SerializeField]

        private float speed;

        [SerializeField]

        private float health;

        [SerializeField]

        private float damage;

       public void Look()
       {


            Debug.Log("Slime is looking at you");

       }


    }

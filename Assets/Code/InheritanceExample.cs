using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class Slime : MonoBehaviour
    {

    protected int cell = 1;

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

     public virtual void run()
     {
        Debug.Log("Slime is rinning");
     }

    public virtual void attack()
    {
        Debug.Log("Slime is attacking");
    }

    


}

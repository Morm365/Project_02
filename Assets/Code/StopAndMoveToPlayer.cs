using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAndMoveToPlayer : MonoBehaviour
{

    public float speed = 2.5f;

    public float distance = 10.0f; //between player and object

    private bool goToPlayer = false;

    private Transform playerTransform;

    private Patrool patroolSlime;



    void Start()
    {

    
     GameObject player = GameObject.FindGameObjectWithTag("Player");  //find the player

      if (player != null)
       {
            playerTransform = player.transform;
       }


          patroolSlime = GetComponent<Patrool>();  //receive script "Patrool" for tis object



        
    }

    
    void Update()
    {

        if (!goToPlayer && playerTransform != null)  
        {  
             
               
            FindThedistanceToPlayer();
        }    

        if (goToPlayer && playerTransform != null) 
        {
               
            FollowToPlayer();
             
               
        }

        void FindThedistanceToPlayer()
        {
            float  distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);

             
            if (distanceToPlayer <= distance)
            {
                StartFollowtoPlayer();



            }
        }

        

        void StartFollowtoPlayer()
        {
            goToPlayer = true; 
               
        
            if (patroolSlime != null) 
            {
                patroolSlime.StopMoving();   
            } 


        }

        void FollowToPlayer()
        {
            transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, speed * Time.deltaTime);        
        }








    }












}

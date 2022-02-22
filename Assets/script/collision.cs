using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{ 

    public box_movement boxMovement;
    public score_script scoreText;
  
    //using collision function
    //and access collision 
    //tagrget obstacle tag
    //when collision hoga cobstacle tag , box movement stop hoge

    void OnCollisionEnter(Collision info)
    {
        // Debug.Log(info.collider.name);

        if(info.collider.tag == "obstacle"){
            Debug.Log("hit me harder");
            boxMovement.enabled = false;
            scoreText.enabled = false;
            //this is the way of refering the game
       
            //here script gameManagment;
            FindObjectOfType<gameManagment>().EndGame();
        }
    }
}

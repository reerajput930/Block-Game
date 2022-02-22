using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box_movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float forwordForce = 500f;
    public float sidewaysForce = 500f;
    public score_script scoreText;



    void FixedUpdate()
    {
        //rigidbody contain function like useGravity , AddForce
        //Time.deltaTime used for same force rate in any archi of pc
        //if one pc has lower framerate(slowspeed) Time.deltaTime will increase and vice versa
        //else one pc high framerate means Time.deltaTime will decrease
        //Hence maintaining the force rate

        rb.AddForce(0, 0, forwordForce * Time.deltaTime);
         
        

        if(Input.GetKey(KeyCode.D)) {

            rb.AddForce(sidewaysForce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A))
        {

            rb.AddForce(-(sidewaysForce* Time.deltaTime), 0,0,ForceMode.VelocityChange);
        }

        //Here if the box falldown we call the endGame function from gamemanagment class
        if(rb.position.y <= -0.6f)
        {
      
            FindObjectOfType<gameManagment>().EndGame();
        }
      

    }
}

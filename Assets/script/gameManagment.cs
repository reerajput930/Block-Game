using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using a unity engind which manages the scene
using UnityEngine.SceneManagement;

public class gameManagment : MonoBehaviour
{
    bool gameHasEnded = false;
   public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game End");

            //now calling a function called restart
            //Restart();

            //calling a invoke function in order to have some delay in restart
            Invoke("Restart", 2f);

        }
    }

    void Restart()
    {  
        //taken from liberary UnityEngine.SceneManagment;
        SceneManager.LoadScene("level1");
    }
}

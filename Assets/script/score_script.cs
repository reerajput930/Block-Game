using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 

public class score_script : MonoBehaviour
{
    public Transform box;
    public Text scoreText;
    public float initialPosition;

    void Start()
    {
     initialPosition = -(box.position.z);
    }

    // Update is called once per frame
    void Update()
    {   
        scoreText.text = (box.position.z + initialPosition).ToString("0");
        //scoreText.text = box.position.z.ToString();
     
    }
}
  
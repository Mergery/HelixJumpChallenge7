using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody playerRB;
    public float bounceForce = 6;


   // pu AudioManager audioManager;// kept giving me errors 

    void Start()
    {
       // audioManager = FindObjectOfType<AudioManager>();
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        FindObjectOfType<AudioManager>().Play("bounce");
        playerRB.velocity = new Vector3(playerRB.velocity.x, bounceForce, playerRB.velocity.z);
        string materialName = collision.transform.GetComponent<MeshRenderer>().material.name;

        if(materialName=="Safe (Instance)")
        {
            // the ball hits the safe 
        }
        else if (materialName=="Unsafe (Instance)")
        {
            GameManager.gameOver = true;
            FindObjectOfType<AudioManager>().Play("game over");
            

        }
        else if(materialName=="LastRing (Instance)" && !GameManager.levelCompleted)
        {
            GameManager.levelCompleted = true; 
            FindObjectOfType<AudioManager>().Play("win level");
            

        }


    }
}

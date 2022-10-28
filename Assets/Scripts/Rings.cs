 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rings : MonoBehaviour
{
    private Transform player;// reference the player
    // Start is called before the first frame update
    void Start()
    {
        player= GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y> player.transform.position.y)
        {
            GameManager.ringsPassed++;
            GameManager.score++;
            FindObjectOfType<AudioManager>().Play("whoosh");
            Destroy(gameObject);
        }
    }
}

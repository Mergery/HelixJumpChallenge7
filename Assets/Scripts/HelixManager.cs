using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixManager : MonoBehaviour
{
    // anarray of the rings 
    public GameObject[] helixRings;
    public float ySpawn =0;
    public float ringDistance= 5.0f;
    public int noRings ;
    public GameObject lastRing;

    void Start()
    {
        noRings = GameManager.currentLevelIndex+5;
        for (int i=0; i<noRings; i++)
        {
            if(i==0)
            {
                SpawnRings(0);
            }
            else 
            {
                SpawnRings(Random.Range(1, helixRings.Length-1));
            }
        }
        SpawnRings(helixRings.Length-1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnRings(int ringIndex)
    {
       GameObject go= Instantiate(helixRings[ringIndex], transform.up*ySpawn, Quaternion.identity);
       go.transform.parent= transform;
        ySpawn-=ringDistance;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    // reference to our 3d models 
    public GameObject[] characters;
    private int selectedCharacter= 0;// the idex for the selected character which by defaeult is 0 our default player 
    
    void Start() // at the start of the game we will disable all characters except our default character
    {
        foreach(GameObject ch in characters)
        {
            ch.SetActive(false); 
        }
        characters [selectedCharacter].SetActive(true); // that is 0 so each time our game starts the ball will be activated and the rest deactivated 
    }

    // function to select the characters 
    public void ChangeCharacter(int newCharacter)
    {
        characters[selectedCharacter].SetActive(false); // that is to disable the selected character
        characters[newCharacter].SetActive(true);
        selectedCharacter= newCharacter; // set the new index as selected character index 
    }

    
    void Update()
    {
        
    }
}

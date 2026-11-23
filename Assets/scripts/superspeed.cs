using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superspeed : MonoBehaviour
{
    [SerializeField] private NewBehaviourScript player;
    [SerializeField] private GameData gameData;
    [SerializeField] private textupdate textupdate;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            textupdate.announcement = "You unlocked a secret artefact! You have superspeed";
            gameData.AddTreasure(1);
            player.moveespeed = 15f; // Set the player's move speed to 20
            Debug.Log("Player has entered the trigger area. Super speed is now enabled.");
            Destroy(gameObject);
        }
    }
}

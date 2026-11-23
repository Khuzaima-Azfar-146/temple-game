using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shrink1 : MonoBehaviour
{
    [SerializeField] private shrink shoot;
    [SerializeField] private GameData gameData;
    [SerializeField] private textupdate textupdate;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            textupdate.announcement = "You collected an artefact! You have gained the ability to roll with the Down button";
            gameData.AddTreasure(1);
            shoot.enabled = true;
            Debug.Log("Player has entered the trigger area. shrinking is now enabled.");
            Destroy(gameObject);
        }
    }
}

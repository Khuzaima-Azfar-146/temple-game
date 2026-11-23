using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{

    [SerializeField] private shoot shoot;
    [SerializeField] private GameData gameData; [SerializeField] private textupdate textupdate;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            textupdate.announcement = "You collected an artefact! have the ability to slash with the Mouse button";
            gameData.ResetData();
            gameData.AddTreasure(1);
            shoot.enabled = true;
            Debug.Log("Player has entered the trigger area. Shooting is now enabled.");
            Destroy(gameObject);
        }
}
}

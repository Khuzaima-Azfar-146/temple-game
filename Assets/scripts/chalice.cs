using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chalice : MonoBehaviour
{
    [SerializeField] private doublejump shoot;
    [SerializeField] private GameData gameData;
    [SerializeField] private textupdate textupdate;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            textupdate.announcement = "you collected an artefact! you have gained the ability to double jump";
            gameData.AddTreasure(1);
            shoot.enabled = true;
            Debug.Log("Player has entered the trigger area. double jumping is now enabled.");
            Destroy(gameObject);
        }
    }
}

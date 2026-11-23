
using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    public countdown countdownScript;
    [SerializeField] private GameData gameData;
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameData.AddTreasure(1);
            gameData.SetTime(Mathf.CeilToInt(countdownScript.timeRemaining));
            SceneManager.LoadScene("end");
        }
    }
}


using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class countdown : MonoBehaviour
{
    public float timeRemaining = 60;
    [SerializeField] private GameData gameData;
    Text display;
    // Start is called before the first frame update
    void Start()
    {
     display = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining <= 0)
        {
            timeRemaining = 0;
            gameData.time = 61;
            SceneManager.LoadScene("end");
        }
        display.text = "Time Remaining: " + Mathf.Ceil(timeRemaining).ToString()+"\nArtefacts collected: "+ gameData.treasures;
    }
}

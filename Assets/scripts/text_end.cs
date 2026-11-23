using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_end : MonoBehaviour
{
    [SerializeField] private GameData gameData;
    Text text;
    [SerializeField] private Image image;

    [SerializeField] private Sprite badend;
    // Start is called before the first frame update
    void Start()
    {
        if (gameData.time > 60)
        {
            image.sprite = badend;
        }
        text = GetComponent<Text>();
        text.text = "You have collected " + gameData.treasures + " treasures!\n" + "Time taken: " + gameData.time + " seconds";
    }

}

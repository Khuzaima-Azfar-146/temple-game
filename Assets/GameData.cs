using UnityEngine;

[CreateAssetMenu(fileName = "NewGameData", menuName = "Game/Game Data")]
public class GameData : ScriptableObject
{
    [Header("Player Progress")]
    public int treasures = 0;
    public int time;

    private void OnEnable()
    {
    }

    public void AddTreasure(int amount = 1)
    {
        treasures += amount;
    }

    public void ResetData()
    {
        treasures = 0;
    }

    public void SetTime(int newTime)
    {
        time = newTime;
    }
}
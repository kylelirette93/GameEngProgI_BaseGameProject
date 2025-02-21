using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Expose fields in inspector.
[System.Serializable]
// Class to hold quest data.
public class Quest
{
    // Quest data.
    public string title;
    public string description;
    public int collected = 0;
    public int condition = 3;
    public int reward;
    public bool isCompleted;
    public bool isRecieved = false;
    

    public void CompleteQuest()
    {
        // Check if the quest is completed.
        if (collected == condition)
        {
            isCompleted = true;
            // Debug.Log("Quest completed: " + title);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuestUI : MonoBehaviour
{
    public TextMeshProUGUI questListText;
    private QuestManager questManager;

    private void Start()
    {
        questManager = FindObjectOfType<QuestManager>();
        UpdateQuestList();
    }

    public void UpdateQuestList()
    {
        // Update the quest list text with information from the quest data.
        questListText.text = "Active Quests:\n";
        if (questManager != null)
        {
            foreach (Quest quest in questManager.GetActiveQuests())
            {
                if (quest != null && quest.isRecieved)
                {
                    questListText.text += "- " + quest.title + ": " + quest.description + "\n" + "Collected: " + quest.collected;
                }
            }
        }
    }

    public IEnumerator DisplayCompletion()
    {
        this.gameObject.SetActive(true);
        // Display a message when quest is completed.
        questListText.text = "Quest completed, you earned 5 gold!";
        yield return new WaitForSeconds(3f);
        UpdateQuestList();
        this.gameObject.SetActive(false);
    }
   
}

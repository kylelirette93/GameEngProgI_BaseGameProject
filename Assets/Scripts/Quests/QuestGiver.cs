using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public string questTitle;

    void OnTriggerEnter2D(Collider2D other)
    {
        // Trigger zone to complete quest, used to turn in quest.
        if (other.CompareTag("Player"))
        {
            QuestManager questManager = FindObjectOfType<QuestManager>();
            questManager.CompleteQuest(questTitle);
            foreach (var quest in questManager.quests)
            {
                if (!quest.isRecieved)
                {
                    // Player has recieved quest.
                    quest.isRecieved = true;
                    GameManager.Instance.questManager.QuestUI.UpdateQuestList();
                }
            }
        }
    }
}
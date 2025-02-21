using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestDialogueTrigger : MonoBehaviour
{
    public string[] questDialogue;

    public string Title;
    List<Quest> activeQuests = new List<Quest>();

    private bool hasTriggered = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Quest quest = GameManager.Instance.questManager.quests.Find(q => q.title == Title);
            if (quest != null && !hasTriggered)
            {

                GameManager.Instance.dialogueManager.DialogueLines = questDialogue;
                hasTriggered = true;
                if (GameManager.Instance.dialogueManager.DialogueLines.Length > 0)
                {
                    GameManager.Instance.dialogueManager.DisplayDialogue();
                    GameManager.Instance.dialogueManager.DialogueLines = new string[0];
                }
            }
                
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestDialogueTrigger : MonoBehaviour
{
    public GameObject QuestDialoguePrefab;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject questDialogue = Instantiate(QuestDialoguePrefab);
        }
    }
}

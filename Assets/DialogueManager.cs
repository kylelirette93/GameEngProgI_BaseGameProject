using System.Collections;
using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialoguePanel;
    public string[] dialogueLines;
    public TextMeshProUGUI dialogueText;

    private void Start()
    {
        dialoguePanel = GameObject.Find("GameManager/UIManager/Canvas/DialoguePanel");
        if (dialoguePanel != null) 
        {
            dialoguePanel.SetActive(true);
        }

        dialogueText = dialoguePanel.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>();
        DisplayDialogue();

    }

    public void DisplayDialogue()
    {
        StartCoroutine(DisplayDialogueCoroutine());
    }

    private IEnumerator DisplayDialogueCoroutine()
    {
        foreach (string line in dialogueLines)
        {
            dialogueText.text = "";
            foreach (char letter in line)             
            {
                dialogueText.text += letter;
                yield return new WaitForSeconds(0.05f);
            }
            yield return new WaitForSeconds(1f);
        }
        dialoguePanel.SetActive(false);
    }
}

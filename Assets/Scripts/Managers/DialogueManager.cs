using System.Collections;
using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialoguePanel;
    public string[] DialogueLines;
    public TextMeshProUGUI dialogueText;

    public void DisplayDialogue()
    {
        if (DialogueLines != null && DialogueLines.Length > 0)
        {
            dialoguePanel.SetActive(true);
            Debug.Log("Activating dialogue panel");
            StartCoroutine(DisplayDialogueCoroutine());
        }    
    }

    private IEnumerator DisplayDialogueCoroutine()
    {
        Time.timeScale = 0f;
        foreach (string line in DialogueLines)
        {
            dialogueText.text = dialogueText.text + "\n";
            foreach (char letter in line)             
            {
                GameManager.Instance.SoundManager.PlaySoundByName("typewriter");
                dialogueText.text += letter;
                yield return new WaitForSecondsRealtime(0.05f);
            }
            yield return new WaitForSecondsRealtime(1f);
        }
        dialoguePanel.SetActive(false);
        Time.timeScale = 1f;
    }
}

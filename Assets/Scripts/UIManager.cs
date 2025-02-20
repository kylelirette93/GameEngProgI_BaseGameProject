using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject optionsPanel;
    public GameObject gameplayPanel;
    public GameObject pausePanel;
    public GameObject questPanel;

    public void EnableMainMenuUI()
    {
        DisableAllMenuUI();
        mainMenuPanel.SetActive(true);
    }

    public void EnableGameplayMenuUI()
    {
        DisableAllMenuUI();
        gameplayPanel.SetActive(true);
    }

    public void EnablePauseMenuUI()
    {
        DisableAllMenuUI();
        pausePanel.SetActive(true);
    }

    public void EnableOptionsUI()
    {
        DisableAllMenuUI();
        optionsPanel.SetActive(true);
    }

    public void EnableQuestUI()
    {
        DisableAllMenuUI();
        questPanel.SetActive(true);
    }

    public void DisableAllMenuUI()
    {
        mainMenuPanel.SetActive(false);
        gameplayPanel.SetActive(false);
        pausePanel.SetActive(false);
        optionsPanel.SetActive(false);
        questPanel.SetActive(false);
    }
}
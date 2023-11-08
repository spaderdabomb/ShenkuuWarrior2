using UnityEngine.UIElements;
using UnityEngine;
using System.Collections.Generic;

public partial class HighscoresMenu
{
    public VisualElement root;
    private List<HighscoreEntryContainer> highscoreEntryContainers;

    public HighscoresMenu(VisualElement root)
    {
        AssignQueryResults(root);

        this.root = root;

        InitMenu();
        RegisterCallbacks();
    }

    private void InitMenu()
    {
        new MenuButtonStandard(backButton);
        SetHighscores();
    }

    private void RegisterCallbacks()
    {
        backButton.clickable.clicked += ReturnToMainMenu;
    }

    private void ReturnToMainMenu()
    {
        MainMenuManager.Instance.mainMenu.ShowMenu(MainMenuType.MainMenu);
    }

    public void SetHighscores()
    {
        highscoreEntryContainers = new();
        Dictionary<string, float> currentEntries = GetHighscoreEntryDict();
        Debug.Log("setting highscores");

        int i = 0;
        foreach (KeyValuePair<string, float> entry in currentEntries)
        {
            VisualElement entryClone = MainMenuManager.Instance.highscoreEntryContainer.CloneTree();
            HighscoreEntryContainer highscoreEntryContainer = new HighscoreEntryContainer(entryClone, i + 1, entry.Key, entry.Value);
            mainContent.Add(entryClone);
            highscoreEntryContainers.Add(highscoreEntryContainer);
            i++;
        }
    }

    private Dictionary<string, float> GetHighscoreEntryDict()
    {
        Dictionary<string, float> entryDict = new();

        for (int i = 0; i < 10; i++)
        {
            string playerName = "player" + i.ToString();
            float score = Random.Range(1, 10000);
            entryDict.Add(playerName, score);
        }

        return entryDict;
    }
}

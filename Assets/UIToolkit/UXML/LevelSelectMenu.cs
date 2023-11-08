using System.Collections.Generic;
using UnityEngine.UIElements;
using UnityEngine;

public partial class LevelSelectMenu
{
    public VisualElement root;
    public List<LevelSelectButton> levelSelectButtons;

    public LevelSelectMenu(VisualElement root)
    {
        AssignQueryResults(root);

        this.root = root;

        InitLevelSelectMenu();
        RegisterCallbacks();
    }

    private void InitLevelSelectMenu()
    {
        levelSelectButtons = new();

        for (int i = 0; i < MainMenuManager.Instance.totalLevels; i++)
        {
            VisualElement levelSelectButtonClone = MainMenuManager.Instance.levelSelectButton.CloneTree();
            LevelSelectButton levelSelectButton = new LevelSelectButton(levelSelectButtonClone, i);
            levelButtonsGroupBox.Add(levelSelectButtonClone);
            levelSelectButtons.Add(levelSelectButton);
        }

        MenuButtonStandard backButtonStandard = new MenuButtonStandard(backButton);
    }

    public void RegisterCallbacks()
    {
        backButton.clickable.clicked += BackButtonClicked;
    }

    public void UnregisterCallbacks()
    {
        backButton.clickable.clicked -= BackButtonClicked;
    }

    public void SetLevelSelectActive()
    {
        levelSelectBg.style.display = DisplayStyle.Flex;
    }

    public void SetLevelSelectInactive()
    {
        levelSelectBg.style.display = DisplayStyle.None;
    }

    private void BackButtonClicked()
    {
        MainMenuManager.Instance.mainMenu.ShowMenu(MainMenuType.MainMenu);
    }
}

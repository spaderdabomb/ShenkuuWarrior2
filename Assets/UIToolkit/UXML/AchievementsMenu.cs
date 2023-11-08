using UnityEngine.UIElements;
using UnityEngine;
using System.Collections.Generic;

public partial class AchievementsMenu
{
    public VisualElement root;
    public List<AchievementContainer> achievementContainers;

    public AchievementsMenu(VisualElement root)
    {
        AssignQueryResults(root);

        this.root = root;

        InitMenu();
        RegisterCallbacks();
    }

    private void InitMenu()
    {
        new MenuButtonStandard(backButton);
        UpdateAchievements();
    }

    public void UpdateAchievements()
    {
        achievementContainers = new();
        int numAchievements = AchievementExtensions.GetTotalAchievements();
        Dictionary<string, AchievementData> achievementDict = AchievementExtensions.GetAchievementDict();

        foreach (var kvp in achievementDict)
        {
            VisualElement achievementClone = MainMenuManager.Instance.achievementContainer.CloneTree();
            AchievementContainer newContainer = new AchievementContainer(achievementClone, kvp.Value);
            mainContent.Add(achievementClone);
            achievementContainers.Add(newContainer);
        }
    }

    private void RegisterCallbacks()
    {
        backButton.clickable.clicked += ReturnToMainMenu;
    }

    private void ReturnToMainMenu()
    {
        MainMenuManager.Instance.mainMenu.ShowMenu(MainMenuType.MainMenu);
    }

    public void DisplayAchievementDescription(AchievementData achievementData)
    {
        descriptionLabel.text = achievementData.description;
    }

    public void HideAchievementDescription()
    {
        descriptionLabel.text = string.Empty;
    }
}

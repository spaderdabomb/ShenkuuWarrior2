using UnityEngine.UIElements;
using UnityEngine;

public partial class AchievementContainer
{
    public AchievementData achievementData;
    public AchievementContainer(VisualElement root, AchievementData achievementData)
    {
        AssignQueryResults(root);

        this.achievementData = achievementData;

        InitContainer();
        RegisterCallbacks();
    }

    private void InitContainer()
    {
        new HoverOnlyStandard(achievementContainer);
        achievementIcon.style.backgroundImage = achievementData.icon.texture;
    }

    private void RegisterCallbacks()
    {
        achievementContainer.RegisterCallback<PointerOverEvent>(OnHover);
        achievementContainer.RegisterCallback<PointerOutEvent>(OnExit);
    }

    public void OnHover(PointerOverEvent evt)
    {
        MainMenuManager.Instance.mainMenu.achievementsMenu.DisplayAchievementDescription(achievementData);
    }

    public void OnExit(PointerOutEvent evt)
    {
        MainMenuManager.Instance.mainMenu.achievementsMenu.HideAchievementDescription();
    }
}

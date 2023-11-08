using UnityEngine.UIElements;
using UnityEngine;

public partial class SettingsMenu
{
    public VisualElement root;

    public SettingsMenu(VisualElement root)
    {
        AssignQueryResults(root);

        this.root = root;

        InitMenu();
        RegisterCallbacks();
    }

    private void InitMenu()
    {
        new MenuButtonStandard(backButton);
    }

    private void RegisterCallbacks()
    {
        backButton.clickable.clicked += ReturnToMainMenu;
    }

    private void ReturnToMainMenu()
    {
        MainMenuManager.Instance.mainMenu.ShowMenu(MainMenuType.MainMenu);
    }
}

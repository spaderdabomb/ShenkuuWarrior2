using UnityEngine.UIElements;
using UnityEngine;

public partial class MainMenuUI
{
    public VisualElement root;
    public HighscoresMenu highscoresMenu;
    public AchievementsMenu achievementsMenu;
    public SettingsMenu settingsMenu;

    public MainMenuUI(VisualElement root)
    {
        AssignQueryResults(root);

        this.root = root;

        InitMainMenu();
        RegisterCallbacks();
    }

    public void RegisterCallbacks()
    {
        highscoresButton.clickable.clicked += () => MenuButtonClicked(MainMenuType.HighscoresMenu);
        achievementsButton.clickable.clicked += () => MenuButtonClicked(MainMenuType.AchievementsMenu);
        settingsButton.clickable.clicked += () => MenuButtonClicked(MainMenuType.SettingsMenu);
        playButton.clickable.clicked += () => MenuButtonClicked(MainMenuType.LevelSelect);
    }

    public void UnregisterCallbacks()
    {
        highscoresButton.clickable.clicked -= () => MenuButtonClicked(MainMenuType.HighscoresMenu);
        achievementsButton.clickable.clicked -= () => MenuButtonClicked(MainMenuType.AchievementsMenu);
        settingsButton.clickable.clicked -= () => MenuButtonClicked(MainMenuType.SettingsMenu);
        playButton.clickable.clicked -= () => MenuButtonClicked(MainMenuType.LevelSelect);
    }

    public void InitMainMenu()
    {
        highscoresMenu = new HighscoresMenu(highscoresMenuRoot);
        achievementsMenu = new AchievementsMenu(achievementsMenuRoot);
        settingsMenu = new SettingsMenu(settingsMenuRoot);

        MenuButtonStandard highscoresButtonStandard = new MenuButtonStandard(highscoresButton);
        MenuButtonStandard achievementsButtonStandard = new MenuButtonStandard(achievementsButton);
        MenuButtonStandard settingsButtonStandard = new MenuButtonStandard(settingsButton);
        MenuButtonStandard playButtonStandard = new MenuButtonStandard(playButton);
    }

    private void MenuButtonClicked(MainMenuType mainMenuType)
    {
        ShowMenu(mainMenuType);
    }

    public void ShowMenu(MainMenuType mainMenuType)
    {
        HideAllMenus();

        if (mainMenuType == MainMenuType.MainMenu)
        {
            mainMenuRoot.style.display = DisplayStyle.Flex;
        }
        else if (mainMenuType == MainMenuType.HighscoresMenu)
        {
            highscoresMenu.root.style.display = DisplayStyle.Flex;
        }
        else if (mainMenuType == MainMenuType.AchievementsMenu)
        {
            achievementsMenu.root.style.display = DisplayStyle.Flex;
        }
        else if (mainMenuType == MainMenuType.SettingsMenu)
        {
            settingsMenu.root.style.display = DisplayStyle.Flex;
        }
        else if (mainMenuType == MainMenuType.LevelSelect)
        {
            MainMenuManager.Instance.levelSelectMenu.SetLevelSelectActive();
        }
    }

    private void HideAllMenus()
    {
        mainMenuRoot.style.display = DisplayStyle.None;
        highscoresMenu.root.style.display = DisplayStyle.None;
        achievementsMenu.root.style.display = DisplayStyle.None;
        settingsMenu.root.style.display = DisplayStyle.None;
        MainMenuManager.Instance.levelSelectMenu.SetLevelSelectInactive();
    }
}

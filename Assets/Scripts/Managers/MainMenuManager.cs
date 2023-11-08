using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MainMenuManager : MonoBehaviour
{
    public static MainMenuManager Instance;
    public int totalLevels;

    public UIDocument mainMenuDocument;
    public UIDocument levelSelectDocument;
    [HideInInspector] public MainMenuUI mainMenu;
    [HideInInspector] public LevelSelectMenu levelSelectMenu;

    // Visual Assets
    public VisualTreeAsset levelSelectButton;
    public VisualTreeAsset highscoreEntryContainer;
    public VisualTreeAsset achievementContainer;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        totalLevels = LevelExtensions.GetTotalLevels();
        mainMenu = new MainMenuUI(mainMenuDocument.rootVisualElement);
        levelSelectMenu = new LevelSelectMenu(levelSelectDocument.rootVisualElement);

    }
}

public enum MainMenuType
{
    MainMenu,
    HighscoresMenu,
    AchievementsMenu,
    SettingsMenu,
    LevelSelect
}

// -----------------------
// script auto-generated
// any changes to this file will be lost on next code generation
// com.quickeye.ui-toolkit-plus ver: 3.0.3
// -----------------------
using UnityEngine.UIElements;

partial class MainMenuUI
{
    private VisualElement mainMenuBg;
    private VisualElement mainMenuRoot;
    private Label mainMenuHeaderLabel;
    private VisualElement mainMenuHeaderSpacer;
    private GroupBox mainMenuButtonGroupBox;
    private Button highscoresButton;
    private Button achievementsButton;
    private Button settingsButton;
    private Button playButton;
    private TemplateContainer highscoresMenuRoot;
    private TemplateContainer achievementsMenuRoot;
    private TemplateContainer settingsMenuRoot;
    
    protected void AssignQueryResults(VisualElement root)
    {
        mainMenuBg = root.Q<VisualElement>("MainMenuBg");
        mainMenuRoot = root.Q<VisualElement>("MainMenuRoot");
        mainMenuHeaderLabel = root.Q<Label>("MainMenuHeaderLabel");
        mainMenuHeaderSpacer = root.Q<VisualElement>("MainMenuHeaderSpacer");
        mainMenuButtonGroupBox = root.Q<GroupBox>("MainMenuButtonGroupBox");
        highscoresButton = root.Q<Button>("HighscoresButton");
        achievementsButton = root.Q<Button>("AchievementsButton");
        settingsButton = root.Q<Button>("SettingsButton");
        playButton = root.Q<Button>("PlayButton");
        highscoresMenuRoot = root.Q<TemplateContainer>("HighscoresMenuRoot");
        achievementsMenuRoot = root.Q<TemplateContainer>("AchievementsMenuRoot");
        settingsMenuRoot = root.Q<TemplateContainer>("SettingsMenuRoot");
    }
}

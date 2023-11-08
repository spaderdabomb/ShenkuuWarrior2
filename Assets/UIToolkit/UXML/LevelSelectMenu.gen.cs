// -----------------------
// script auto-generated
// any changes to this file will be lost on next code generation
// com.quickeye.ui-toolkit-plus ver: 3.0.3
// -----------------------
using UnityEngine.UIElements;

partial class LevelSelectMenu
{
    private VisualElement levelSelectBg;
    private VisualElement levelSelectMenuRoot;
    private Label levelSelectHeaderLabel;
    private GroupBox levelButtonsGroupBox;
    private VisualElement bottomRegion;
    private Button backButton;
    
    protected void AssignQueryResults(VisualElement root)
    {
        levelSelectBg = root.Q<VisualElement>("LevelSelectBg");
        levelSelectMenuRoot = root.Q<VisualElement>("LevelSelectMenuRoot");
        levelSelectHeaderLabel = root.Q<Label>("LevelSelectHeaderLabel");
        levelButtonsGroupBox = root.Q<GroupBox>("LevelButtonsGroupBox");
        bottomRegion = root.Q<VisualElement>("BottomRegion");
        backButton = root.Q<Button>("BackButton");
    }
}

// -----------------------
// script auto-generated
// any changes to this file will be lost on next code generation
// com.quickeye.ui-toolkit-plus ver: 3.0.3
// -----------------------
using UnityEngine.UIElements;

partial class AchievementsMenu
{
    private VisualElement menuRoot;
    private Label headerLabel;
    private VisualElement headerSpacer;
    private VisualElement mainContent;
    private Label descriptionLabel;
    private VisualElement bottomSpacer;
    private Button backButton;
    
    protected void AssignQueryResults(VisualElement root)
    {
        menuRoot = root.Q<VisualElement>("MenuRoot");
        headerLabel = root.Q<Label>("HeaderLabel");
        headerSpacer = root.Q<VisualElement>("HeaderSpacer");
        mainContent = root.Q<VisualElement>("MainContent");
        descriptionLabel = root.Q<Label>("DescriptionLabel");
        bottomSpacer = root.Q<VisualElement>("BottomSpacer");
        backButton = root.Q<Button>("BackButton");
    }
}

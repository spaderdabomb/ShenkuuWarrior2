// -----------------------
// script auto-generated
// any changes to this file will be lost on next code generation
// com.quickeye.ui-toolkit-plus ver: 3.0.3
// -----------------------
using UnityEngine.UIElements;

partial class SettingsMenu
{
    private VisualElement menuRoot;
    private Label headerLabel;
    private VisualElement headerSpacer;
    private VisualElement mainContent;
    private Button backButton;
    
    protected void AssignQueryResults(VisualElement root)
    {
        menuRoot = root.Q<VisualElement>("MenuRoot");
        headerLabel = root.Q<Label>("HeaderLabel");
        headerSpacer = root.Q<VisualElement>("HeaderSpacer");
        mainContent = root.Q<VisualElement>("MainContent");
        backButton = root.Q<Button>("BackButton");
    }
}

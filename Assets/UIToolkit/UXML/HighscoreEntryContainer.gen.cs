// -----------------------
// script auto-generated
// any changes to this file will be lost on next code generation
// com.quickeye.ui-toolkit-plus ver: 3.0.3
// -----------------------
using UnityEngine.UIElements;

partial class HighscoreEntryContainer
{
    private VisualElement entryContainerRoot;
    private Label rankLabel;
    private Label nameLabel;
    private Label scoreLabel;
    
    protected void AssignQueryResults(VisualElement root)
    {
        entryContainerRoot = root.Q<VisualElement>("EntryContainerRoot");
        rankLabel = root.Q<Label>("RankLabel");
        nameLabel = root.Q<Label>("NameLabel");
        scoreLabel = root.Q<Label>("ScoreLabel");
    }
}

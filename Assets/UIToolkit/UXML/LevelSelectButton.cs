using UnityEngine.UIElements;
using UnityEngine;

public partial class LevelSelectButton : MenuButtonStandard
{
    public int levelNum;

    public LevelSelectButton(VisualElement root, int levelNum) : base(root)
    {
        AssignQueryResults(root);

        this.levelNum = levelNum;

        InitButton();
    }


    private void InitButton()
    {
        levelSelectButton.text = levelNum.ToString();
    }

    public override void ButtonClicked()
    {
        base.ButtonClicked();
        Debug.Log(levelNum);
    }

    public override void ButtonHovered(PointerOverEvent evt)
    {
        base.ButtonHovered(evt);
    }
}

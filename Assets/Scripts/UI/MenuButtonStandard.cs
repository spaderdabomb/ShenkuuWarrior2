using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using JSAM;

public class MenuButtonStandard : Button
{
    Button button;

    public MenuButtonStandard(VisualElement root)
    {
        button = FindButtonInChildren(root);
        if (button != null)
        {
            InitStandardButton();
            RegisterCallbacks();
        }
        else
        {
            Debug.Log("Button not found.");
        }
    }

    public MenuButtonStandard(Button button)
    {
        this.button = button;
        InitStandardButton();
        RegisterCallbacks();
    }

    private void InitStandardButton()
    {

    }

    private void RegisterCallbacks()
    {
        button.clickable.clicked += ButtonClicked;
        button.RegisterCallback<PointerOverEvent>(ButtonHovered);
    }

    private void UnregisterCallbacks()
    {
        button.clickable.clicked -= ButtonClicked;
        button.UnregisterCallback<PointerOverEvent>(ButtonHovered);
    }

    public virtual void ButtonClicked()
    {
        AudioManager.PlaySound(MainLibrarySounds.MenuButtonClick);
    }

    public virtual void ButtonHovered(PointerOverEvent evt)
    {
        AudioManager.PlaySound(MainLibrarySounds.MenuButtonHover);
    }

    private Button FindButtonInChildren(VisualElement parent)
    {
        Button button = parent.Q<Button>();

        if (button != null)
        {
            return button;
        }
        else
        {
            foreach (VisualElement child in parent.Children())
            {
                button = FindButtonInChildren(child);
                if (button != null)
                {
                    return button;
                }
            }
        }

        return null;
    }
}

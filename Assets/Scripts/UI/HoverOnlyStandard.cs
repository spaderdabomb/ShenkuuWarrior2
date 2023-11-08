using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using JSAM;

public class HoverOnlyStandard
{
    public VisualElement root;
    public HoverOnlyStandard(VisualElement root)
    {
        this.root = root;
        RegisterCallbacks();
    }

    private void RegisterCallbacks()
    {
        root.RegisterCallback<PointerOverEvent>(OnHover);
    }

    public void UnregisterCallbacks()
    {
        root.UnregisterCallback<PointerOverEvent>(OnHover);
    }

    public virtual void OnHover(PointerOverEvent evt)
    {
        AudioManager.PlaySound(MainLibrarySounds.MenuButtonHover);
        Debug.Log("Playing audio");
    }
}

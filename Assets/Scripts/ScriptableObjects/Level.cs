using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[CreateAssetMenu(fileName = "LevelTemplate", menuName = "ShenkuuWarrior2/Level")]
public class Level : SerializedScriptableObject
{
    public int levelNum = -1;

    private void OnValidate()
    {
        // SetDirty("Level" + levelNum.ToString());
    }
}

public static class LevelExtensions
{
    private static readonly Dictionary<int, Level> _levels = new Dictionary<int, Level>();
    public static Level GetLevel(int levelNum)
    {
        if (_levels.Count <= 0)
        {
            var sObjects = Resources.LoadAll<Level>("ScriptableObjects/Levels");
            foreach (var sObject in sObjects)
            {
                _levels.Add(sObject.levelNum, sObject);
            }
        }

        if (_levels.TryGetValue(levelNum, out Level level))
        {
            return level;
        }

        Debug.LogWarning($"Item not found: {levelNum}");
        return null;
    }

    public static int GetTotalLevels()
    {
        if (_levels.Count <= 0)
        {
            var sObjects = Resources.LoadAll<Level>("ScriptableObjects/Levels");
            foreach (var sObject in sObjects)
            {
                _levels.Add(sObject.levelNum, sObject);
            }
        }

        return _levels.Count;
    }
}

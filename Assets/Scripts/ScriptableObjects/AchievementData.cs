using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[CreateAssetMenuAttribute(fileName = "AchievementData", menuName = "ShenkuuWarrior2/Achievement")]
public class AchievementData : SerializedScriptableObject
{
    public string id;
    public string displayName;
    public string description;
    public Sprite icon;

    private void OnValidate()
    {
        // SetDirty
        id = this.name;
    }
}

public static class AchievementExtensions
{
    private static readonly Dictionary<string, AchievementData> _achievements = new Dictionary<string, AchievementData>();

    public static Dictionary<string, AchievementData> GetAchievementDict()
    {
        return _achievements;
    }

    public static AchievementData GetAchievement(string id)
    {
        if (_achievements.Count <= 0)
        {
            var sObjects = Resources.LoadAll<AchievementData>("ScriptableObjects/Achievements");
            foreach (var sObject in sObjects)
            {
                _achievements.Add(sObject.id, sObject);
            }
        }

        if (_achievements.TryGetValue(id, out AchievementData achievement))
        {
            return achievement;
        }

        Debug.LogWarning($"Achievement not found: {id}");
        return null;
    }

    public static int GetTotalAchievements()
    {
        if (_achievements.Count <= 0)
        {
            var sObjects = Resources.LoadAll<AchievementData>("ScriptableObjects/Achievements");
            foreach (var sObject in sObjects)
            {
                _achievements.Add(sObject.id, sObject);
            }
        }

        return _achievements.Count;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public float MasterVolume { get; set; } = 1f;
    public float SfxVolume { get; set; } = 1f;
    public float MusicVolume { get; set; } = 1f;

    public int CurrentMaxLevel { get; set; } = 1;
    public float TotalDistanceClimbed { get; set; } = 1;
    public Dictionary<string, bool> AchievementsComplete { get; set; } = new();


    private void Awake()
    {
        if (Instance)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        Instance = this;
    }

    private void LoadAllData()
    {
        MasterVolume = ES3.Load(nameof(MasterVolume), MasterVolume);
        SfxVolume = ES3.Load(nameof(SfxVolume), SfxVolume);
        MusicVolume = ES3.Load(nameof(MusicVolume), MusicVolume);
        CurrentMaxLevel = ES3.Load(nameof(CurrentMaxLevel), CurrentMaxLevel);
        TotalDistanceClimbed = ES3.Load(nameof(TotalDistanceClimbed), TotalDistanceClimbed);
        AchievementsComplete = ES3.Load(nameof(AchievementsComplete), AchievementsComplete);
    }

    private void SaveAllData()
    {
        ES3.Save(nameof(MasterVolume), MasterVolume);
        ES3.Save(nameof(SfxVolume), SfxVolume);
        ES3.Save(nameof(MusicVolume), MusicVolume);
        ES3.Save(nameof(CurrentMaxLevel), CurrentMaxLevel);
        ES3.Save(nameof(TotalDistanceClimbed), TotalDistanceClimbed);
        ES3.Save(nameof(AchievementsComplete), AchievementsComplete);
    }

    private void OnApplicationQuit()
    {
        SaveAllData();
    }
}

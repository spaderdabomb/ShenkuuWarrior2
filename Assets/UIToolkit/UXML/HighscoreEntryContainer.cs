using UnityEngine.UIElements;
using UnityEngine;

public partial class HighscoreEntryContainer
{
    public int Rank { get; private set; }
    public string PlayerName { get; private set; }
    public float Score { get; private set; }

    public HighscoreEntryContainer(VisualElement root, int rank, string playerName, float score)
    {
        AssignQueryResults(root);

        Rank = rank;
        PlayerName = playerName;
        Score = score;

        InitContainer();
    }

    private void InitContainer()
    {
        rankLabel.text = Rank.ToString() + ".";
        nameLabel.text = PlayerName;
        scoreLabel.text = Score.ToString("0");
    }
}

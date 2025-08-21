using UnityEngine;
using TMPro;

public class BirdStatsDisplay : MonoBehaviour
{
    public BirdStats birdStats;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dragText;
    public TextMeshProUGUI resistanceText;

    public void UpdateDisplay(BirdStats stats)
    {
        birdStats = stats;

        nameText.text = stats.birdName;
        dragText.text = $"Drag Coefficient: {stats.dragCoefficient}";
        resistanceText.text = $"Air Resistance: {stats.airResistance}";
    }
}

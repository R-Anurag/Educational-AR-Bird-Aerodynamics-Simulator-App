using UnityEngine;

public class BirdController : MonoBehaviour
{
    public GameObject[] birdModels;
    public BirdStats[] birdStats;
    public BirdStatsDisplay display;

    private int currentIndex = 0;

    void Start()
    {
        ShowBird(0);
    }

    public void SwitchBird()
    {
        currentIndex = (currentIndex + 1) % birdModels.Length;
        ShowBird(currentIndex);
    }

    void ShowBird(int index)
    {
        for (int i = 0; i < birdModels.Length; i++)
        {
            birdModels[i].SetActive(i == index);
        }

        if (display != null && birdStats.Length > index)
        {
            display.UpdateDisplay(birdStats[index]);
        }
    }
}

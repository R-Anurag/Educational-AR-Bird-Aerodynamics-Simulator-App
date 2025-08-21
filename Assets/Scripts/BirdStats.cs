using UnityEngine;

[CreateAssetMenu(fileName = "NewBirdStats", menuName = "Bird/Stats", order = 1)]
public class BirdStats : ScriptableObject
{
    public string birdName;
    public float dragCoefficient;
    public string airResistance; // You can use enum too
}

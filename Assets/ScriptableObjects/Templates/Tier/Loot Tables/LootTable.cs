using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "LootTable", menuName = "Scriptable Objects/LootTable")]
public class LootTable : ScriptableObject
{
    public Tier FirstPossibleTier;
    public int FirstPossibleTier_Chance;
    public Tier SecondPossibleTier;
    public int SecondPossibleTier_Chance;
    public Tier ThirdPossibleTier;
    public int ThirdPossibleTier_Chance;
    public Tier FourthPossibleTier;
    public int FourthPossibleTier_Chance;
    public int TotalChance;
    private int ChosenNumber;
    private int CumulativeChance;

    private void OnEnable()
    {
        TotalChance = 101;
    }

    public void DrawATier()
    {
        ChosenNumber = Random.Range(1, TotalChance);
        CumulativeChance = FirstPossibleTier_Chance;

        if(ChosenNumber < FirstPossibleTier_Chance)
        {
            Debug.Log(FirstPossibleTier.DrawAWeapon().WeaponName);
            return;
        }
        CumulativeChance += SecondPossibleTier_Chance;
        if(ChosenNumber < CumulativeChance)
        {
            Debug.Log(SecondPossibleTier.DrawAWeapon().WeaponName);
            return;
        }
        CumulativeChance += ThirdPossibleTier_Chance;
        if(ChosenNumber < CumulativeChance)
        {
            Debug.Log(ThirdPossibleTier.DrawAWeapon().WeaponName);
            return;
        }
        CumulativeChance += FourthPossibleTier_Chance;
        if(ChosenNumber < CumulativeChance)
        {
            Debug.Log(FourthPossibleTier.DrawAWeapon().WeaponName);
            return;
        }
        else
        {
            Debug.Log("You fucked up lol");
        }
    }
}

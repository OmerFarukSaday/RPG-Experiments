using UnityEngine;

[CreateAssetMenu(fileName = "Sword", menuName = "Loot/Weapon/Sword")]
public class Sword : Weapon
{
    private void OnEnable()
    {
        FireRate = 3;
        Range = 5;
    }
}

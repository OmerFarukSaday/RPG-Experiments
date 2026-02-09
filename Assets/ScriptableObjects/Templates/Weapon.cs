using UnityEngine;

public enum WeaponType
{
    Sword,
    Knife,
    Spear,
    Bow
}

[CreateAssetMenu(fileName = "Weapon", menuName = "Loot/Weapon")]
public class Weapon : ScriptableObject
{
    public WeaponType Type;
    public string WeaponName;
    public float Damage;
    public float FireRate;
    public float Range;
    public GameObject ItemInDroppedForm;
    public GameObject ProjectilePrefab;

    private void OnValidate()
    {
        WeaponName = name;
        switch (Type)
        {
            case WeaponType.Sword: FireRate = 3; Range = 3; break;
        }
    }
}

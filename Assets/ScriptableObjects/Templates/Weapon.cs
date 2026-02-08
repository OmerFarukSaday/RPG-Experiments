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
    public Tier WeaponTier;
    public TierDatabase TierDB;
    public int WeaponTier_Number;
    public float Damage;
    public float FireRate;
    public float Range;
    public GameObject ItemInDroppedForm;
    public GameObject ProjectilePrefab;

    private void OnValidate()
    {
        foreach (var IndividualTier in TierDB.TierList)
        {
            if(IndividualTier.TierNumber == WeaponTier_Number)
            {
                WeaponTier = IndividualTier;
            }
        }

        switch (Type)
        {
            case WeaponType.Sword: FireRate = 3; Range = 3; break;
        }
    }
}

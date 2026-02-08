using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Loot/Weapon")]
public class Weapon : ScriptableObject
{
    public string WeaponName;
    public float Damage;
    public float FireRate;
    public float Range;
    public GameObject ItemInDroppedForm;
}

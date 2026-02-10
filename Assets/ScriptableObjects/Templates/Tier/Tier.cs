using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Tier", menuName = "Loot/Tier")]
public class Tier : ScriptableObject
{
    public int TierNumber;
    public List<Weapon> WhatWeaponsDoesThisTierHave;
    private int ChosenWeapon_Number;
    private Weapon ChosenWeapon;

    public Weapon DrawAWeapon()
    {
        ChosenWeapon_Number = Random.Range(0, WhatWeaponsDoesThisTierHave.Count);
        ChosenWeapon = WhatWeaponsDoesThisTierHave[ChosenWeapon_Number];
        return ChosenWeapon;
    }
}

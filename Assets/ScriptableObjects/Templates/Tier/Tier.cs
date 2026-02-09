using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Tier", menuName = "Loot/Tier")]
public class Tier : ScriptableObject
{
    public int TierNumber;
    public List<Weapon> WhatWeaponsDoesThisTierBelongTo;
    private int ChosenWeapon_Number;
    private Weapon ChosenWeapon;

    public Weapon DrawAWeapon()
    {
        ChosenWeapon_Number = Random.Range(0, WhatWeaponsDoesThisTierBelongTo.Count);
        ChosenWeapon = WhatWeaponsDoesThisTierBelongTo[ChosenWeapon_Number];
        return ChosenWeapon;
    }
}

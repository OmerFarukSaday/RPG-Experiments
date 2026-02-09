using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Tier", menuName = "Loot/Tier")]
public class Tier : ScriptableObject
{
    public int TierNumber;
    public List<Weapon> WhatWeaponsDoesThisTierBelongTo;
}

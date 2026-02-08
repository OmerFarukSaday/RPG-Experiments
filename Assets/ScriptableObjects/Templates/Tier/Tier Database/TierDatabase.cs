using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Data/TierDatabase")]
public class TierDatabase : ScriptableObject
{
    public List<Tier> TierList;
}

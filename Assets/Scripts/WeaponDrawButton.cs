using UnityEngine;

public class WeaponDrawButton : MonoBehaviour
{
    public LootTable LootTableUsed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClicked()
    {
        LootTableUsed.DrawATier();
    }
}

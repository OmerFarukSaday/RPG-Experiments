using UnityEngine;

public class BasicEnemyBehaviour : MonoBehaviour
{
    public int CurrentHealth;
    public int MaxHealth;
    public LootTable LootTableUsed;
    public GameObject ProjectilePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDeath()
    {
        LootTableUsed.DrawATier();
    }
}

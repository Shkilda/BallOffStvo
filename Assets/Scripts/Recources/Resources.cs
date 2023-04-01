using UnityEngine;

abstract public class Resources : MonoBehaviour
{
    public float CurrentDurability;
    public float MaxDurability;
    public int weight;
    public int hardness;
    public float SpawnChance;
    public int quantity;


    void Start()
    {
        
    }
    protected void Spawn()
    {
        
    }
    public void TakeDamage(GameObject ore, float damage)
    {

        CurrentDurability -= damage;
        if (CurrentDurability <= 0)
        {
            Destroy(ore);
        }
    }
}


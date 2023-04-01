using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronOre : Resources, ISpawnable
{

    private void Awake()
    {
        MaxDurability = 100;
        CurrentDurability = MaxDurability;
        weight = 1;
        SpawnChance = 50;
        hardness = 0;
    }

    void Start()
    {
        


    }

    public void Spawn(int amount, Vector3 position, GameObject ore)
    {
        Instantiate(this.gameObject);
    }

    public void Destroy(GameObject ore)
    {
        throw new System.NotImplementedException();
    }

    ~IronOre()
    {
        
    }
}

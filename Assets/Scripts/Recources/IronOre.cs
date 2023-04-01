using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronOre : Resources
{
   
    // Start is called before the first frame update
    void Start()
    {
        MaxDurability = 100;
        CurrentDurability = MaxDurability;
        weight = 1;
        SpawnChance = 50;
        hardness = 0;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

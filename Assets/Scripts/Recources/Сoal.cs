using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : Resources
{
    // Start is called before the first frame update
    void Start()
    {
        MaxDurability = 100;
        CurrentDurability = MaxDurability;
        weight = 2;
        SpawnChance = 75;
        hardness = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

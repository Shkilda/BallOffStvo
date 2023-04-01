 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Resources : MonoBehaviour
{
    public float CurrentDurability;
    public float MaxDurability;
    public int weight;
    public int hardness;
    public float SpawnChance;
    public int quantity;


    public Resources _Resources;

    void Start()
    {
        _Resources = this.gameObject.GetComponent<Resources>();

    }
    public void TakeDamage(GameObject Character, float damage)
    {

        CurrentDurability -= damage;
        if (CurrentDurability <= 0)
        {
            Destroy(Character);
        }
    }


        
     
    // Start is called before the first frame update
  

    // Update is called once per frame
  
    
}


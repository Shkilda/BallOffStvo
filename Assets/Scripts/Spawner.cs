using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Vector3 center;
    public Vector3 size;
    public IronOre iron;
    public GameObject sphere;

    private void Start()
    {
        IronOre iron = new IronOre();
    }

    private void Update()
    {
        
    }
    public void Spawn(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
            Instantiate(iron, pos, Quaternion.identity);
        }
        //Vector3 pos2 = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2)); 
        //Instantiate(sphere, pos2, Quaternion.identity);
        //Count++;

    }
}

using System.Collections.Generic;
using UnityEngine;

public interface ISpawnable
{
    List<GameObject> ore = new List<GameObject>();

    void Spawn(int  amount, Vector3 position, GameObject ore);
    void Destroy(GameObject ore);
}

public List<GameObject>
{ 
}

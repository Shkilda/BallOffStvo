using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tools : MonoBehaviour
{
    public float Damage = 10;
    public float Durability;
    public int Strength;

    private Resources _Resources;

    public void OnTriggerStay(Collider  other)
    {
        if(other.gameObject.tag == "Resources")
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                Debug.Log("kopaet");
                _Resources = other.GetComponent<Resources>();
                _Resources.TakeDamage(other.gameObject, Damage);
            }
         



        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

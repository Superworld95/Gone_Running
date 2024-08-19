using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallspot : MonoBehaviour
{
         
     public void SpawnThing() {
        print("This is supposed to spawn a wall.");
     Pooling.Instance.SpawnFromPool("Wall 1", transform.position, transform.rotation);
     
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

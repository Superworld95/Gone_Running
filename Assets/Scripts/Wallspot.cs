using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Pool;

public class Wallspot : MonoBehaviour
{
    private Transform t, tChild = null;
    public Transform thePlayer;
    private GameObject obj, childObj;
    bool set1 = false, set2 = false, set3 = false;
    public void SpawnThing(string h, Transform b) {
        //Debug.Log(t.name+" spawns a wall!");
        //Debug.Log(t.position.z - thePlayer.position.z);
        Pooling.Instance.SpawnFromPool(h, b.transform.position, b.transform.rotation, b);
    }
    public void RemoveThing(GameObject b)
    {
        Debug.Log(t.position.z - thePlayer.position.z);
        Pooling.Instance.RecallToPool(b);
    }

     

    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Transform>();    
    }

    // Update is called once per frame
    void Update()
    {

        if (t.position.z - thePlayer.position.z <= 130 && t.position.z - thePlayer.position.z >= 0 && set1 == false)
        {
            switch (t.name)
            {
                case "Wall Spot A":
                    SpawnThing("TwoSide", t);
                    break;
                case "Wall Spot B":
                    SpawnThing("LowGround", t);
                    break;
                case "Wall Spot C":
                    SpawnThing("MiddleWall", t);
                    break;
            }
            set1 = true;
        }
        else if (t.position.z - thePlayer.position.z <= 160 && t.position.z - thePlayer.position.z >= 135 && set2 == false)
        {
            switch (t.name)
            {
                case "Wall Spot A":
                    RemoveThing(childObj);
                    break;
                case "Wall Spot B":
                    RemoveThing(childObj);
                    break;
                case "Wall Spot C":
                    RemoveThing(childObj);
                    break;
                case "Wall Spot D":
                    SpawnThing("TwoSide", t);
                    break;
                case "Wall Spot E":
                    SpawnThing("LowGround", t);
                    break;
                case "Wall Spot F":
                    SpawnThing("MiddleWall", t);
                    break;
            }
            set2 = true;
        }
        if (set1 && (t.name == "Wall Spot A" || t.name == "Wall Spot B" || t.name == "Wall Spot C") && tChild == null && t.GetChild(0) != null)
        {
            tChild = t.GetChild(0);
            //tChild = GetComponent<Transform>;
            childObj = tChild.gameObject;
        }
        if (set2 && (t.name == "Wall Spot D" || t.name == "Wall Spot E" || t.name == "Wall Spot F") && tChild == null && t.GetChild(0) != null)
        {
            tChild = t.GetChild(0);
            childObj = tChild.gameObject;
        }
    }
}

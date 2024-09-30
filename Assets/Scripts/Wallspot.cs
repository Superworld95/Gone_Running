using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Pool;

public class Wallspot : MonoBehaviour
{
    public Transform t, thePlayer;
    //, tChild = null;
    //private GameObject childObj;
    //private int set = 0;
    //public int setPoint = 0;
    int rounds = 0;


    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if ((t.position.z - thePlayer.position.z <= 100) && (t.position.z - thePlayer.position.z >= 0))
        {
            switch (t.name)
            {
                case "Wall Spot A":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("TwoSide", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("LowGround", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("MiddleWall", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;
                case "Wall Spot B":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("LowGround", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("LowGround2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("TwoSide", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;
                case "Wall Spot C":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("MiddleWall", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("MiddleWall", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("LowGround", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;
                case "Wall Spot D":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("LowGround2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("TwoSide", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("TwoSide2", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;
                case "Wall Spot E":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("TwoSide2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("LowGround", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("LowGround2", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;
                case "Wall Spot F":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("MiddleWall2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("MiddleWall", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("MiddleWall", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;

                case "Wall Spot G":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("TwoSide", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("TwoSide", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("LowGround", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;
                case "Wall Spot H":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("LowGround", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("LowGround", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("TwoSide", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;
                case "Wall Spot I":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("MiddleWall", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("LowGround2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("TwoSide2", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;
                case "Wall Spot J":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("LowGround2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("TwoSide", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("MiddleWall", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;
                case "Wall Spot K":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("TwoSide2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("MiddleWall", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("LowGround", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;
                case "Wall Spot L":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("MiddleWall2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("LowGround", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("TwoSide", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;

                case "Wall Spot M":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("TwoSide", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("MiddleWall2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("LowGround2", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;
                case "Wall Spot N":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("LowGround", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("TwoSide", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("MiddleWall", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;
                case "Wall Spot O":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("MiddleWall", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("LowGround", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("TwoSide", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;
                case "Wall Spot P":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("LowGround2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("TwoSide2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("MiddleWall2", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;
                case "Wall Spot Q":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("TwoSide2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("MiddleWall2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("LowGround2", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;
                case "Wall Spot R":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("MiddleWall2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("LowGround2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("TwoSide2", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;

                case "Wall Spot S":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("TwoSide", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("MiddleWall", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("LowGround", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;
                case "Wall Spot T":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("LowGround", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("TwoSide", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("MiddleWall", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;
                case "Wall Spot U":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("MiddleWall", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("LowGround", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("TwoSide", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;
                case "Wall Spot V":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("LowGround2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("TwoSide2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("MiddleWall2", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;
                case "Wall Spot W":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("TwoSide2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("MiddleWall2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("LowGround2", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;
                case "Wall Spot X":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("MiddleWall2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("LowGround2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("TwoSide2", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;

                case "Wall Spot Y":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("TwoSide2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("MiddleWall2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("LowGround2", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;
                case "Wall Spot Z":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("MiddleWall2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 1:
                            Pooling.Instance.SpawnFromPool("LowGround2", t.transform.position, t.transform.rotation, t);
                            break;
                        case 2:
                            Pooling.Instance.SpawnFromPool("TwoSide2", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;
                default: break;
            }
            if (t.position.z - thePlayer.position.z < 0)
            {
                rounds++;
            }

        }
    }
}


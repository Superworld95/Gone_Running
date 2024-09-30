using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Pool;

public class Enemyspot : MonoBehaviour
{
    public Transform t, thePlayer;
    int rounds = 0;
     

    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if ((t.position.z - thePlayer.position.z <= 130) && (t.position.z - thePlayer.position.z >= 0))
        {
            switch (t.name)
            {
                case "Enemy Spot A":
                    switch (rounds % 3)
                    {
                        case 0:
                            Pooling.Instance.SpawnFromPool("SidetoSideEnemy", t.transform.position, t.transform.rotation, t);
                            break;
                    }
                    break;
                case "Enemy Spot B":
                    Pooling.Instance.SpawnFromPool("JumperEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot C":
                    Pooling.Instance.SpawnFromPool("JumpwhenEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot D":
                    Pooling.Instance.SpawnFromPool("SidetoSideEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot E":
                    Pooling.Instance.SpawnFromPool("JumpwhenEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot F":
                    Pooling.Instance.SpawnFromPool("SideandJump", t.transform.position, t.transform.rotation, t);
                    break;

                case "Enemy Spot G":
                    Pooling.Instance.SpawnFromPool("SidetoSideEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot H":
                    Pooling.Instance.SpawnFromPool("JumperEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot I":
                    Pooling.Instance.SpawnFromPool("JumpwhenEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot J":
                    Pooling.Instance.SpawnFromPool("SidetoSideEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot K":
                    Pooling.Instance.SpawnFromPool("JumpwhenEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot L":
                    Pooling.Instance.SpawnFromPool("SideandJump", t.transform.position, t.transform.rotation, t);
                    break;

                case "Enemy Spot M":
                    Pooling.Instance.SpawnFromPool("SidetoSideEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot N":
                    Pooling.Instance.SpawnFromPool("JumperEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot O":
                    Pooling.Instance.SpawnFromPool("JumpwhenEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot P":
                    Pooling.Instance.SpawnFromPool("SidetoSideEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot Q":
                    Pooling.Instance.SpawnFromPool("JumpwhenEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot R":
                    Pooling.Instance.SpawnFromPool("SideandJump", t.transform.position, t.transform.rotation, t);
                    break;

                case "Enemy Spot S":
                    Pooling.Instance.SpawnFromPool("SidetoSideEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot T":
                    Pooling.Instance.SpawnFromPool("JumperEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot U":
                    Pooling.Instance.SpawnFromPool("JumpwhenEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot V":
                    Pooling.Instance.SpawnFromPool("SidetoSideEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot W":
                    Pooling.Instance.SpawnFromPool("JumpwhenEnemy", t.transform.position, t.transform.rotation, t);
                    break;
                case "Enemy Spot X":
                    Pooling.Instance.SpawnFromPool("SideandJump", t.transform.position, t.transform.rotation, t);
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

